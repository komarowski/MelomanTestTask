namespace MelomanTestTask.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdentificationNumberCols : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Companies", "IdentificationNumber", c => c.Long(nullable: false));
            AlterColumn("dbo.Employees", "IdentificationNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "IdentificationNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Companies", "IdentificationNumber", c => c.Int(nullable: false));
        }
    }
}
