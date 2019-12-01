namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12220191224 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StaffId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherCourses", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.TeacherCourses", "CourseId", "dbo.Courses");
            DropIndex("dbo.TeacherCourses", new[] { "StaffId" });
            DropIndex("dbo.TeacherCourses", new[] { "CourseId" });
            DropTable("dbo.TeacherCourses");
        }
    }
}
