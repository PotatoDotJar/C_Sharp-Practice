namespace DotNetFrameworkRefresh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.String(),
                        Model = c.String(),
                        IdentificationNumber = c.String(),
                        Mileage = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.cars");
        }
    }
}
