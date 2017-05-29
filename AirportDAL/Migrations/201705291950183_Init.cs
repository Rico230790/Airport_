namespace AirportDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FlightMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FligthId = c.Int(nullable: false),
                        FlightStatus = c.Int(nullable: false),
                        SourceLocationTime = c.DateTime(nullable: false),
                        DestinationTime = c.DateTime(nullable: false),
                        SourceCity = c.String(),
                        DestinationCity = c.String(),
                        Gate = c.String(),
                        Terminal = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlightId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        FlightClass = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FlightMs", t => t.FlightId, cascadeDelete: true)
                .Index(t => t.FlightId);
            
            CreateTable(
                "dbo.Passengers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gender = c.Int(nullable: false),
                        FName = c.String(),
                        LName = c.String(),
                        BirthDat = c.DateTime(nullable: false),
                        Pasport = c.String(),
                        Nationality = c.String(),
                        Ticket_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tickets", t => t.Ticket_Id)
                .Index(t => t.Ticket_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "FlightId", "dbo.FlightMs");
            DropForeignKey("dbo.Passengers", "Ticket_Id", "dbo.Tickets");
            DropIndex("dbo.Passengers", new[] { "Ticket_Id" });
            DropIndex("dbo.Tickets", new[] { "FlightId" });
            DropTable("dbo.Passengers");
            DropTable("dbo.Tickets");
            DropTable("dbo.FlightMs");
        }
    }
}
