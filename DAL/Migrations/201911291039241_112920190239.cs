namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _112920190239 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Room = c.Int(nullable: false),
                        Capacity = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Homework",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        Marks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.CourseID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.StudentLeaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                        Days = c.Int(nullable: false),
                        Reason = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.StudentsInSections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionID = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sections", t => t.SectionID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.SectionID)
                .Index(t => t.StudentID);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SectionName = c.String(),
                        GradeID = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.GradeID, cascadeDelete: true)
                .Index(t => t.GradeID);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.TeacherCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseID = c.Int(nullable: false),
                        StaffID = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Staffs", t => t.StaffID, cascadeDelete: true)
                .Index(t => t.CourseID)
                .Index(t => t.StaffID);
            
            CreateTable(
                "dbo.CourseExams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeacherCourseID = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                        Marks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TeacherCourses", t => t.TeacherCourseID, cascadeDelete: true)
                .Index(t => t.TeacherCourseID);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffID = c.Int(nullable: false),
                        BasicSalary = c.Single(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.StaffID, cascadeDelete: true)
                .Index(t => t.StaffID);
            
            CreateTable(
                "dbo.StaffLeaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffID = c.Int(nullable: false),
                        FromDate = c.DateTime(),
                        ToDate = c.DateTime(),
                        Days = c.Int(nullable: false),
                        Reason = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.StaffID, cascadeDelete: true)
                .Index(t => t.StaffID);
            
            CreateTable(
                "dbo.StaffSalaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffID = c.Int(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LeaveCount = c.Int(nullable: false),
                        Overtime = c.Int(nullable: false),
                        Month = c.DateTime(),
                        BankAccount = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Staffs", t => t.StaffID, cascadeDelete: true)
                .Index(t => t.StaffID);
            
            CreateTable(
                "dbo.ExamTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamType_Name = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExamTypeID = c.Int(nullable: false),
                        ExamName = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExamTypes", t => t.ExamTypeID, cascadeDelete: true)
                .Index(t => t.ExamTypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "ExamTypeID", "dbo.ExamTypes");
            DropForeignKey("dbo.TeacherCourses", "StaffID", "dbo.Staffs");
            DropForeignKey("dbo.StaffSalaries", "StaffID", "dbo.Staffs");
            DropForeignKey("dbo.StaffLeaves", "StaffID", "dbo.Staffs");
            DropForeignKey("dbo.Salaries", "StaffID", "dbo.Staffs");
            DropForeignKey("dbo.CourseExams", "TeacherCourseID", "dbo.TeacherCourses");
            DropForeignKey("dbo.TeacherCourses", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Homework", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Tests", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Tests", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.StudentsInSections", "StudentID", "dbo.Students");
            DropForeignKey("dbo.StudentsInSections", "SectionID", "dbo.Sections");
            DropForeignKey("dbo.Sections", "GradeID", "dbo.Grades");
            DropForeignKey("dbo.StudentLeaves", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Homework", "CourseID", "dbo.Courses");
            DropIndex("dbo.Exams", new[] { "ExamTypeID" });
            DropIndex("dbo.StaffSalaries", new[] { "StaffID" });
            DropIndex("dbo.StaffLeaves", new[] { "StaffID" });
            DropIndex("dbo.Salaries", new[] { "StaffID" });
            DropIndex("dbo.CourseExams", new[] { "TeacherCourseID" });
            DropIndex("dbo.TeacherCourses", new[] { "StaffID" });
            DropIndex("dbo.TeacherCourses", new[] { "CourseID" });
            DropIndex("dbo.Tests", new[] { "CourseID" });
            DropIndex("dbo.Tests", new[] { "StudentID" });
            DropIndex("dbo.Sections", new[] { "GradeID" });
            DropIndex("dbo.StudentsInSections", new[] { "StudentID" });
            DropIndex("dbo.StudentsInSections", new[] { "SectionID" });
            DropIndex("dbo.StudentLeaves", new[] { "StudentID" });
            DropIndex("dbo.Homework", new[] { "StudentID" });
            DropIndex("dbo.Homework", new[] { "CourseID" });
            DropTable("dbo.Exams");
            DropTable("dbo.ExamTypes");
            DropTable("dbo.StaffSalaries");
            DropTable("dbo.StaffLeaves");
            DropTable("dbo.Salaries");
            DropTable("dbo.CourseExams");
            DropTable("dbo.TeacherCourses");
            DropTable("dbo.Tests");
            DropTable("dbo.Sections");
            DropTable("dbo.StudentsInSections");
            DropTable("dbo.StudentLeaves");
            DropTable("dbo.Homework");
            DropTable("dbo.ClassRooms");
        }
    }
}
