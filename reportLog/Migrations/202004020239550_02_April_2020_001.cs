namespace reportLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02_April_2020_001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmailListings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmailListings");
        }
    }
}
