namespace periodontist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeColumnName : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetRoles", "Description");
            RenameColumn(table: "dbo.AspNetRoles", name: "Description1", newName: "Description");
            AddColumn("dbo.AspNetRoles", "DescriptionRole", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "DescriptionRole");
            RenameColumn(table: "dbo.AspNetRoles", name: "Description", newName: "Description1");
            AddColumn("dbo.AspNetRoles", "Description", c => c.String());
        }
    }
}
