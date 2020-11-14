namespace DotNetFrameworkRefresh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCarService : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.services", "ServiceHours", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.services", "ServiceNotes", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.services", "ServiceNotes");
            DropColumn("dbo.services", "ServiceHours");
        }
    }
}
