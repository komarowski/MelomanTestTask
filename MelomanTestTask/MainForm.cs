using MelomanTestTask.Domain.Entities;
using MelomanTestTask.Domain.Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace MelomanTestTask
{
  public partial class MainForm : Form
  {
    private static bool isReadyForFireEvents;
    private readonly CompanyService companyService;
    private readonly EmployeeService employeeService;

    public MainForm()
    {
      InitializeComponent();
      gridViewCompany.SelectionChanged += DataGridViewCompany_SelectionChanged;
      gridViewEmployee.UserDeletingRow += DataGridViewEmployee_UserDeletingRow;
      gridViewEmployee.CellEndEdit += DataGridViewEmployee_CellEndEdit;
      gridViewCompany.UserDeletingRow += DataGridViewCompany_UserDeletingRow;
      gridViewCompany.CellEndEdit += DataGridViewCompany_CellEndEdit;

      //gets registered dependencies
      companyService = (CompanyService)Program.ServiceProvider.GetService(typeof(CompanyService));
      employeeService = (EmployeeService)Program.ServiceProvider.GetService(typeof(EmployeeService));
      UpdateCompanyList();
    }

    /// <summary>
    /// Fills in the table with companies.
    /// </summary>
    private void UpdateCompanyList()
    {
      var companyList = companyService.GetCompanytList();
      isReadyForFireEvents = false;
      gridViewCompany.Rows.Clear();
      foreach (var company in companyList)
      {
        gridViewCompany.Rows.Add(company.Id, company.Name, company.TaxNumber, company.Address, company.Note);
      }
      isReadyForFireEvents = true;
    }

    /// <summary>
    /// Fills in the table with employees.
    /// </summary>
    /// <param name="companyId">Company Id.</param>
    private void UpdateEmployeeList(int companyId)
    {     
      var employeeList = employeeService.GetEmployeeList(companyId);
      isReadyForFireEvents = false;
      gridViewEmployee.Rows.Clear();
      foreach (var employee in employeeList)
      {
        gridViewEmployee.Rows.Add(employee.Id, employee.FirstName, employee.LastName, employee.Patronymic, employee.IdentificationNumber);
      }
      isReadyForFireEvents = true;
    }

    /// <summary>
    /// Tries to get the record id from a row. 
    /// </summary>
    /// <param name="row">Table row.</param>
    /// <param name="columnIndex">Column index with record id.</param>
    /// <param name="id">Record id.</param>
    /// <returns>true, if the cell contains id.</returns>
    private static bool TryGetRowId(DataGridViewRow row, int columnIndex, out int id)
    {
      id = -1;
      var cellValue = row.Cells[columnIndex].Value;
      if (cellValue != null)
      {
        id = (int)cellValue;
        return true;
      }
      return false;
    }
 
    /// <summary>
    /// Fills in the table with employees when selecting a company.
    /// </summary>
    private void DataGridViewCompany_SelectionChanged(object sender, EventArgs e)
    {
      if (gridViewCompany.SelectedRows.Count > 0 
        && TryGetRowId(gridViewCompany.SelectedRows[0], 0, out int id))
      {
        UpdateEmployeeList(id);
      }
    }

    /// <summary>
    /// Deletes an employee record from database.
    /// </summary>
    private void DataGridViewEmployee_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
      if (isReadyForFireEvents && TryGetRowId(e.Row, 0, out int id))
      {
        try
        {
          employeeService.Delete(id);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Error");
        }
      }
    }

    /// <summary>
    /// Gets employee for update or add.
    /// </summary>
    /// <param name="rowIndex">Row index with eployee record.</param>
    /// <returns>Employee or null if not found.</returns>
    private Employee GetEmployeeForUpdate(int rowIndex)
    {
      if (TryGetRowId(gridViewEmployee.Rows[rowIndex], 0, out int id))
      {
        return employeeService.Get(id);
      }
      if (gridViewCompany.SelectedRows.Count > 0
          && TryGetRowId(gridViewCompany.SelectedRows[0], 0, out int companyId))
      {
        return new Employee() { CompanyId = companyId };
      }
      return null;
    }

    /// <summary>
    /// Adds or updates an employee record in database.
    /// </summary>
    private void DataGridViewEmployee_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      if (isReadyForFireEvents)
      {
        Employee employee = GetEmployeeForUpdate(e.RowIndex);
        if (employee == null)
        {
          return;
        }
        var cellValue = gridViewEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        var dataPropertyName = gridViewEmployee.Columns[e.ColumnIndex].DataPropertyName;     
        try
        {
          var propertyInfo = typeof(Employee).GetProperty(dataPropertyName);
          propertyInfo.SetValue(employee, Convert.ChangeType(cellValue, propertyInfo.PropertyType));
          employeeService.Update(employee);
          UpdateEmployeeList(employee.CompanyId);
        }
        catch (Exception ex)
        {
          gridViewEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
          MessageBox.Show(ex.Message, "Error");
        }
        finally
        {
          isReadyForFireEvents = true;
        }
      }
    }

    /// <summary>
    /// Deletes a company record from database.
    /// </summary>
    private void DataGridViewCompany_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
      if (isReadyForFireEvents && TryGetRowId(e.Row, 0, out int id))
      {
        try
        {
          companyService.Delete(id);
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.Message, "Error");
        }
      }
    }

    /// <summary>
    /// Adds or updates an company record in database.
    /// </summary>
    private void DataGridViewCompany_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      if (isReadyForFireEvents)
      {
        Company company = TryGetRowId(gridViewCompany.Rows[e.RowIndex], 0, out int id) 
          ? companyService.Get(id) 
          : new Company();
        var cellValue = gridViewCompany.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        var dataPropertyName = gridViewCompany.Columns[e.ColumnIndex].DataPropertyName;
        if (company != null)
        {
          try
          {
            var propertyInfo = typeof(Company).GetProperty(dataPropertyName);
            propertyInfo.SetValue(company, Convert.ChangeType(cellValue, propertyInfo.PropertyType));
            companyService.Update(company);
            UpdateCompanyList();
          }
          catch (Exception ex)
          {
            gridViewCompany.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
            MessageBox.Show(ex.Message, "Error");
          }
          finally
          {
            isReadyForFireEvents = true;
          }
        }
      }
    }

    /// <summary>
    /// Imports employee records to the selected company.
    /// </summary>
    private void btnImport_Click(object sender, EventArgs e)
    {
      if (gridViewCompany.SelectedRows.Count > 0
          && TryGetRowId(gridViewCompany.SelectedRows[0], 0, out int companyId))
      {
        OpenFileDialog openFileDialog = new OpenFileDialog
        {
          Filter = "CSV files (*.csv)|*.csv"
        };
        DialogResult result = openFileDialog.ShowDialog();
        if (result == DialogResult.OK)
        {
          try
          {
            employeeService.Import(openFileDialog.FileName, companyId);
            UpdateEmployeeList(companyId);
          }
          catch (IOException ex)
          {
            MessageBox.Show(ex.Message, "Error");
          }
        }
      }
      else
      {
        MessageBox.Show("Company not selected", "Warning");
      }
    }

    /// <summary>
    /// Exports employee records from the selected company.
    /// </summary>
    private void btnExport_Click(object sender, EventArgs e)
    {
      if (gridViewCompany.SelectedRows.Count > 0
          && TryGetRowId(gridViewCompany.SelectedRows[0], 0, out int companyId))
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog
        {
          Title = "Save csv file",
          DefaultExt = "csv",
          Filter = "CSV files (*.csv)|*.csv"
        };
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
          employeeService.Export(saveFileDialog.FileName, companyId);
        }
      }
      else
      {
        MessageBox.Show("Company not selected", "Warning");
      }
    }
  }
}
