namespace HW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Favourites",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Station_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stations", t => t.Station_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Station_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Start = c.DateTime(nullable: false),
                        Finish = c.DateTime(nullable: false),
                        Interval = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RouteStations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TimeFromBeg = c.Int(nullable: false),
                        TimeFromFin = c.Int(nullable: false),
                        Station_Id = c.Int(),
                        Route_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Stations", t => t.Station_Id)
                .ForeignKey("dbo.Routes", t => t.Route_Id)
                .Index(t => t.Station_Id)
                .Index(t => t.Route_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Favourites", "User_Id", "dbo.Users");
            DropForeignKey("dbo.RouteStations", "Route_Id", "dbo.Routes");
            DropForeignKey("dbo.RouteStations", "Station_Id", "dbo.Stations");
            DropForeignKey("dbo.Favourites", "Station_Id", "dbo.Stations");
            DropIndex("dbo.RouteStations", new[] { "Route_Id" });
            DropIndex("dbo.RouteStations", new[] { "Station_Id" });
            DropIndex("dbo.Favourites", new[] { "User_Id" });
            DropIndex("dbo.Favourites", new[] { "Station_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.RouteStations");
            DropTable("dbo.Routes");
            DropTable("dbo.Stations");
            DropTable("dbo.Favourites");
        }
    }
}
