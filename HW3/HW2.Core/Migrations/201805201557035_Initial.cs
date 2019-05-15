namespace HW2.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PathElements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StationId = c.Int(nullable: false),
                        Distance = c.Int(nullable: false),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Routes", t => t.RouteId, cascadeDelete: true)
                .ForeignKey("dbo.Stations", t => t.StationId, cascadeDelete: true)
                .Index(t => t.StationId)
                .Index(t => t.RouteId);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Number = c.Int(nullable: false, identity: true),
                        FirstDeparture = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        LastDeparture = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Interval = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Number);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PathElements", "StationId", "dbo.Stations");
            DropForeignKey("dbo.PathElements", "RouteId", "dbo.Routes");
            DropIndex("dbo.PathElements", new[] { "RouteId" });
            DropIndex("dbo.PathElements", new[] { "StationId" });
            DropTable("dbo.Users");
            DropTable("dbo.Stations");
            DropTable("dbo.Routes");
            DropTable("dbo.PathElements");
        }
    }
}
