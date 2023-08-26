namespace MelomanTestTask
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.gridViewCompany = new System.Windows.Forms.DataGridView();
      this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.TaxNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label1 = new System.Windows.Forms.Label();
      this.gridViewEmployee = new System.Windows.Forms.DataGridView();
      this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.IdentificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label2 = new System.Windows.Forms.Label();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.btnImport = new System.Windows.Forms.Button();
      this.btnExport = new System.Windows.Forms.Button();
      this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.mSSQLContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.mSSQLContextBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridViewCompany
      // 
      this.gridViewCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridViewCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyId,
            this.CompanyName,
            this.TaxNumber,
            this.Address,
            this.Note});
      this.gridViewCompany.Location = new System.Drawing.Point(13, 44);
      this.gridViewCompany.Name = "gridViewCompany";
      this.gridViewCompany.RowHeadersWidth = 51;
      this.gridViewCompany.RowTemplate.Height = 24;
      this.gridViewCompany.Size = new System.Drawing.Size(1092, 226);
      this.gridViewCompany.TabIndex = 2;
      // 
      // CompanyId
      // 
      this.CompanyId.HeaderText = "Company Id";
      this.CompanyId.MinimumWidth = 6;
      this.CompanyId.Name = "CompanyId";
      this.CompanyId.ReadOnly = true;
      this.CompanyId.Visible = false;
      this.CompanyId.Width = 125;
      // 
      // CompanyName
      // 
      this.CompanyName.DataPropertyName = "Name";
      this.CompanyName.HeaderText = "Company name";
      this.CompanyName.MinimumWidth = 6;
      this.CompanyName.Name = "CompanyName";
      this.CompanyName.Width = 125;
      // 
      // TaxNumber
      // 
      this.TaxNumber.DataPropertyName = "TaxNumber";
      this.TaxNumber.HeaderText = "Tax number";
      this.TaxNumber.MinimumWidth = 6;
      this.TaxNumber.Name = "TaxNumber";
      this.TaxNumber.Width = 125;
      // 
      // Address
      // 
      this.Address.DataPropertyName = "Address";
      this.Address.HeaderText = "Address";
      this.Address.MinimumWidth = 6;
      this.Address.Name = "Address";
      this.Address.Width = 225;
      // 
      // Note
      // 
      this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Note.DataPropertyName = "Note";
      this.Note.HeaderText = "Note";
      this.Note.MinimumWidth = 6;
      this.Note.Name = "Note";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(12, 11);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 27);
      this.label1.TabIndex = 3;
      this.label1.Text = "Company list";
      // 
      // gridViewEmployee
      // 
      this.gridViewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.gridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.FirstName,
            this.LastName,
            this.Patronymic,
            this.IdentificationNumber});
      this.gridViewEmployee.Location = new System.Drawing.Point(13, 41);
      this.gridViewEmployee.Name = "gridViewEmployee";
      this.gridViewEmployee.RowHeadersWidth = 51;
      this.gridViewEmployee.RowTemplate.Height = 24;
      this.gridViewEmployee.Size = new System.Drawing.Size(1092, 241);
      this.gridViewEmployee.TabIndex = 4;
      // 
      // EmployeeId
      // 
      this.EmployeeId.HeaderText = "EmployeeId";
      this.EmployeeId.MinimumWidth = 6;
      this.EmployeeId.Name = "EmployeeId";
      this.EmployeeId.ReadOnly = true;
      this.EmployeeId.Visible = false;
      this.EmployeeId.Width = 125;
      // 
      // FirstName
      // 
      this.FirstName.DataPropertyName = "FirstName";
      this.FirstName.HeaderText = "First name";
      this.FirstName.MinimumWidth = 6;
      this.FirstName.Name = "FirstName";
      this.FirstName.Width = 125;
      // 
      // LastName
      // 
      this.LastName.DataPropertyName = "LastName";
      this.LastName.HeaderText = "Last name";
      this.LastName.MinimumWidth = 6;
      this.LastName.Name = "LastName";
      this.LastName.Width = 125;
      // 
      // Patronymic
      // 
      this.Patronymic.DataPropertyName = "Patronymic";
      this.Patronymic.HeaderText = "Patronymic";
      this.Patronymic.MinimumWidth = 6;
      this.Patronymic.Name = "Patronymic";
      this.Patronymic.Width = 125;
      // 
      // IdentificationNumber
      // 
      this.IdentificationNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.IdentificationNumber.DataPropertyName = "IdentificationNumber";
      this.IdentificationNumber.HeaderText = "Identification number";
      this.IdentificationNumber.MinimumWidth = 6;
      this.IdentificationNumber.Name = "IdentificationNumber";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(12, 11);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(121, 27);
      this.label2.TabIndex = 5;
      this.label2.Text = "Employee list";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainer1.Location = new System.Drawing.Point(-1, -3);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.gridViewCompany);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.btnExport);
      this.splitContainer1.Panel2.Controls.Add(this.btnImport);
      this.splitContainer1.Panel2.Controls.Add(this.gridViewEmployee);
      this.splitContainer1.Panel2.Controls.Add(this.label2);
      this.splitContainer1.Size = new System.Drawing.Size(1122, 583);
      this.splitContainer1.SplitterDistance = 285;
      this.splitContainer1.TabIndex = 6;
      // 
      // btnImport
      // 
      this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.btnImport.Location = new System.Drawing.Point(936, 11);
      this.btnImport.Name = "btnImport";
      this.btnImport.Size = new System.Drawing.Size(75, 23);
      this.btnImport.TabIndex = 6;
      this.btnImport.Text = "Import";
      this.btnImport.UseVisualStyleBackColor = true;
      this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
      // 
      // btnExport
      // 
      this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.btnExport.Location = new System.Drawing.Point(1030, 11);
      this.btnExport.Name = "btnExport";
      this.btnExport.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btnExport.Size = new System.Drawing.Size(75, 23);
      this.btnExport.TabIndex = 7;
      this.btnExport.Text = "Export";
      this.btnExport.UseVisualStyleBackColor = true;
      this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
      // 
      // companyBindingSource
      // 
      this.companyBindingSource.DataSource = typeof(MelomanTestTask.Domain.Entities.Company);
      // 
      // mSSQLContextBindingSource
      // 
      this.mSSQLContextBindingSource.DataSource = typeof(MelomanTestTask.Infrastructure.MSSQLContext);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1120, 579);
      this.Controls.Add(this.splitContainer1);
      this.Name = "MainForm";
      this.Text = "Meloman Test Task";
      ((System.ComponentModel.ISupportInitialize)(this.gridViewCompany)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewEmployee)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.mSSQLContextBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.BindingSource companyBindingSource;
    private System.Windows.Forms.BindingSource mSSQLContextBindingSource;
    private System.Windows.Forms.DataGridView gridViewCompany;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView gridViewEmployee;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
    private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
    private System.Windows.Forms.DataGridViewTextBoxColumn TaxNumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
    private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
    private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
    private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
    private System.Windows.Forms.DataGridViewTextBoxColumn IdentificationNumber;
    private System.Windows.Forms.Button btnImport;
    private System.Windows.Forms.Button btnExport;
  }
}

