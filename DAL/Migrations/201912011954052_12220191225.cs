namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12220191225 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tests", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Tests", "CourseId", "dbo.Courses");
            DropIndex("dbo.Tests", new[] { "CourseId" });
            DropIndex("dbo.Tests", new[] { "StudentId" });
            DropTable("dbo.Tests");
        }
    }
}
