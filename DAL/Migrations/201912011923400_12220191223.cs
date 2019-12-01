namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12220191223 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserSelectedTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserTypeId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.UserTypes", t => t.UserTypeId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.UserTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserSelectedTypes", "UserTypeId", "dbo.UserTypes");
            DropForeignKey("dbo.UserSelectedTypes", "UserId", "dbo.Users");
            DropIndex("dbo.UserSelectedTypes", new[] { "UserTypeId" });
            DropIndex("dbo.UserSelectedTypes", new[] { "UserId" });
            DropTable("dbo.UserSelectedTypes");
        }
    }
}
