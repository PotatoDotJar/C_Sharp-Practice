namespace DotNetFrameworkRefresh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCarService : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarId = c.Int(nullable: false),
                        ServiceDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.cars", t => t.CarId, cascadeDelete: true)
                .Index(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.services", "CarId", "dbo.cars");
            DropIndex("dbo.services", new[] { "CarId" });
            DropTable("dbo.services");
        }
    }
}
