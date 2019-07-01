namespace periodontist.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArticleViewModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Text = c.String(),
                        Date = c.DateTime(nullable: false),
                        AuthorName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ArticleViewModels");
        }
    }
}
