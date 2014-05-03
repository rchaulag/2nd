namespace LinqCrud.database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelUpdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teams", "Name", c => c.String());
            AlterColumn("dbo.Teams", "Location", c => c.String());
            AlterColumn("dbo.Teams", "HeadCoach", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "HeadCoach", c => c.Int(nullable: false));
            AlterColumn("dbo.Teams", "Location", c => c.Int(nullable: false));
            AlterColumn("dbo.Teams", "Name", c => c.Int(nullable: false));
        }
    }
}
