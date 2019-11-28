namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11282019542 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserSelectedTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        UserTypeID = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.UserTypes", t => t.UserTypeID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.UserTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserSelectedTypes", "UserTypeID", "dbo.UserTypes");
            DropForeignKey("dbo.UserSelectedTypes", "UserID", "dbo.Users");
            DropIndex("dbo.UserSelectedTypes", new[] { "UserTypeID" });
            DropIndex("dbo.UserSelectedTypes", new[] { "UserID" });
            DropTable("dbo.UserSelectedTypes");
        }
    }
}
