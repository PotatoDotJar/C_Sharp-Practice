namespace DotNetFrameworkRefresh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTypesToNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.cars", "Make", c => c.String(nullable: false));
            AlterColumn("dbo.cars", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.cars", "IdentificationNumber", c => c.String(nullable: false));
            AlterColumn("dbo.services", "ServiceNotes", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.services", "ServiceNotes", c => c.String());
            AlterColumn("dbo.cars", "IdentificationNumber", c => c.String());
            AlterColumn("dbo.cars", "Model", c => c.String());
            AlterColumn("dbo.cars", "Make", c => c.String());
        }
    }
}
