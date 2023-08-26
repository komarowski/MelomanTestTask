namespace MelomanTestTask.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameCompanyTaxNumberCol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "TaxNumber", c => c.Long(nullable: false));
            DropColumn("dbo.Companies", "IdentificationNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "IdentificationNumber", c => c.Long(nullable: false));
            DropColumn("dbo.Companies", "TaxNumber");
        }
    }
}
