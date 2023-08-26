namespace MelomanTestTask.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeLastNameCol : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Companies", "Address", c => c.String(maxLength: 100));
            AlterColumn("dbo.Companies", "Note", c => c.String(maxLength: 200));
            AlterColumn("dbo.Employees", "FirstName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Employees", "LastName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Employees", "Patronymic", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Patronymic", c => c.String());
            AlterColumn("dbo.Employees", "LastName", c => c.Int(nullable: false));
            AlterColumn("dbo.Employees", "FirstName", c => c.String());
            AlterColumn("dbo.Companies", "Note", c => c.String());
            AlterColumn("dbo.Companies", "Address", c => c.String());
            AlterColumn("dbo.Companies", "Name", c => c.String());
        }
    }
}
