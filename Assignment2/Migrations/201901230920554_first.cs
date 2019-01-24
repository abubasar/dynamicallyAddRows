namespace Assignment2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        SalesAreaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SalesAreas", t => t.SalesAreaId, cascadeDelete: true)
                .Index(t => t.SalesAreaId);
            
            CreateTable(
                "dbo.SalesAreas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AreaCode = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "SalesAreaId", "dbo.SalesAreas");
            DropIndex("dbo.Customers", new[] { "SalesAreaId" });
            DropTable("dbo.SalesAreas");
            DropTable("dbo.Customers");
        }
    }
}
