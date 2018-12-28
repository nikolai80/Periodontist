namespace periodontist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewFieldToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "IsUserDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
        }
    }
}
