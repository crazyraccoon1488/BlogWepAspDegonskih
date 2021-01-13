namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        IdCategory = c.Int(nullable: false, identity: true),
                        NameCategory = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdCategory);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        TextComment = c.String(nullable: false),
                        CurrentDate = c.DateTime(nullable: false),
                        IdCategory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.IdCategory, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser)
                .Index(t => t.IdCategory);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nick = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        CurrentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Posts", "IdCategory", "dbo.Categories");
            DropIndex("dbo.Posts", new[] { "IdCategory" });
            DropIndex("dbo.Posts", new[] { "IdUser" });
            DropTable("dbo.Users");
            DropTable("dbo.Posts");
            DropTable("dbo.Categories");
        }
    }
}
