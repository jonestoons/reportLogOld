namespace reportLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _05_04_2020_001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookingID = c.Double(nullable: false),
                        RiderID = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        PickupLocation = c.String(),
                        DeliveryLocation = c.String(),
                        ConfirmationStatus = c.Boolean(nullable: false),
                        ConfirmationTime = c.DateTime(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyID = c.Single(nullable: false),
                        Description = c.String(),
                        Address = c.String(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        SbDate = c.DateTime(nullable: false),
                        SbExpiry = c.DateTime(nullable: false),
                        subMode = c.Int(nullable: false),
                        CurrentPackageType = c.Int(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CompanyCustomers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyID = c.Int(nullable: false),
                        FullName = c.String(),
                        AltCode = c.String(),
                        Email = c.String(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        Address = c.String(),
                        AreaCode = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Riders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserID = c.Single(nullable: false),
                        CompanyID = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        OtherName = c.String(),
                        Phone = c.String(),
                        Password = c.String(),
                        Address = c.String(),
                        DoB = c.DateTime(nullable: false),
                        NextOfKin = c.String(),
                        NextOfKinNumber = c.String(),
                        SbDate = c.DateTime(nullable: false),
                        SbExpiry = c.DateTime(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubPackages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        subMode = c.Int(nullable: false),
                        Description = c.String(),
                        AltCode = c.String(),
                        Amount = c.Single(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TID = c.Double(nullable: false),
                        CompanyID = c.Int(nullable: false),
                        RiderID = c.Int(nullable: false),
                        PickupLocation = c.String(),
                        DeliveryLocation = c.String(),
                        PayType = c.Int(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        DeliveryTime = c.DateTime(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "CompanyID", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "RegisteredDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "RegisteredDate");
            DropColumn("dbo.AspNetUsers", "CompanyID");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropTable("dbo.Transactions");
            DropTable("dbo.SubPackages");
            DropTable("dbo.Riders");
            DropTable("dbo.CompanyCustomers");
            DropTable("dbo.Companies");
            DropTable("dbo.Bookings");
        }
    }
}
