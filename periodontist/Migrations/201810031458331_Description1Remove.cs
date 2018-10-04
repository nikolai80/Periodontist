namespace periodontist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Description1Remove : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetRoles", "Description1");
        }
        
        public override void Down()
        {
        }
    }
}
