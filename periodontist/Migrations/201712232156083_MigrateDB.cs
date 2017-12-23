namespace periodontist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserQuestions", "Theme", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserQuestions", "Theme");
        }
    }
}
