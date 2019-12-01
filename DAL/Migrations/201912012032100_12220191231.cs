namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12220191231 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentInSections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.SectionID)
                .Index(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentInSections", "StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentInSections", "SectionID", "dbo.Sections");
            DropIndex("dbo.StudentInSections", new[] { "StudentID" });
            DropIndex("dbo.StudentInSections", new[] { "SectionID" });
            DropTable("dbo.StudentInSections");
        }
    }
}
