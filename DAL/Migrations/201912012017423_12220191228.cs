namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12220191228 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Homework",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Total = c.Int(nullable: false),
                        marks = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Homework", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Homework", "CourseID", "dbo.Courses");
            DropIndex("dbo.Homework", new[] { "CourseID" });
            DropIndex("dbo.Homework", new[] { "StudentID" });
            DropTable("dbo.Homework");
        }
    }
}
