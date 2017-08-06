namespace BlogSnippet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class metadata : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BlogPosts", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.BlogPosts", "Content", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BlogPosts", "Content", c => c.String());
            AlterColumn("dbo.BlogPosts", "Title", c => c.String());
        }
    }
}
