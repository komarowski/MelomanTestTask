using CsvHelper;
using MelomanTestTask.Domain.Entities;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace MelomanTestTask.Domain.Services
{
  /// <summary>
  /// Logic of working with <see cref="Employee"/> entity.
  /// </summary>
  public class EmployeeService
  {
    private readonly IRepository repository;

    /// <summary>
    /// Public constructor for <seealso cref="EmployeeService"/>.
    /// </summary>
    /// <param name="projectRepository"><seealso cref="IRepository"/> implementation.</param>
    public EmployeeService(IRepository projectRepository)
    {
      this.repository = projectRepository;
    }

    /// <summary>
    /// Gets all employees by company Id.
    /// </summary>
    /// <param name="companyId">Company Id.</param>
    /// <returns>IEnumerable of Employee.</returns>
    public IEnumerable<Employee> GetEmployeeList(int companyId)
    {
      return repository.GetList<Employee>(x => x.CompanyId == companyId);
    }

    /// <summary>
    /// Gets employee by employee Id.
    /// </summary>
    /// <param name="employeeyId">Employee Id.</param>
    /// <returns>Employee or null if not found.</returns>
    public Employee Get(int employeeyId)
    {
      return repository.Get<Employee>(employeeyId);
    }

    /// <summary>
    /// Adds or updates an employee record.
    /// </summary>
    /// <param name="employee">Employee information.</param>
    /// <returns>Saved employee.</returns>
    public Employee Update(Employee employee)
    {
      return repository.Update(employee);
    }

    /// <summary>
    /// Deletes an employee record.
    /// </summary>
    /// <param name="id">Employee Id.</param>
    public void Delete(int id)
    {
      repository.Delete<Employee>(id);
    }

    /// <summary>
    /// Export employee list to csv.
    /// </summary>
    /// <param name="path">File path to save.</param>
    /// <param name="companyId">Company Id.</param>
    public void Export(string path, int companyId)
    {
      var employeeList = GetEmployeeList(companyId);
      using (var writer = new StreamWriter(path))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.WriteRecords(employeeList);
      }
    }

    /// <summary>
    /// Import employee list from csv.
    /// </summary>
    /// <param name="path">Source csv file path.</param>
    /// <param name="companyId">Company Id.</param>
    public void Import(string path, int companyId)
    {
      var employeeList = new List<Employee>();
      using (TextReader fileReader = File.OpenText(path))
      {
        var csv = new CsvReader(fileReader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<Employee>();
        employeeList.AddRange(records);
      }
      foreach (var employee in employeeList)
      {
        employee.Company = null;
        employee.Id = 0;
        employee.CompanyId = companyId;
        Update(employee);
      }
    }
  }
}
