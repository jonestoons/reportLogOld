namespace reportLog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _06_04_2020_001 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Riders", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Riders", "UserID", c => c.Single(nullable: false));
        }
    }
}
