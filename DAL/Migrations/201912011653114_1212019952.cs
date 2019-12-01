namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1212019952 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GradeName = c.String(),
                        Class = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsRead = c.Boolean(nullable: false),
                        IsAdd = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        Edit = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                        PageID = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pages", t => t.PageID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.PageID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        EmailAddress = c.String(),
                        Telephone = c.String(),
                        Status = c.Boolean(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TimeLoggedIn = c.DateTime(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FathersName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                        HiringDate = c.DateTime(nullable: false),
                        StaffTypeId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaffTypes", t => t.StaffTypeId, cascadeDelete: true)
                .Index(t => t.StaffTypeId);
            
            CreateTable(
                "dbo.StaffTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffTypeName = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        FathersName = c.String(),
                        Age = c.Int(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        AddmissionDate = c.DateTime(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "StaffTypeId", "dbo.StaffTypes");
            DropForeignKey("dbo.UserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.Sessions", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "PageID", "dbo.Pages");
            DropIndex("dbo.Staffs", new[] { "StaffTypeId" });
            DropIndex("dbo.Sessions", new[] { "UserId" });
            DropIndex("dbo.UserRoles", new[] { "PageID" });
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropTable("dbo.Students");
            DropTable("dbo.StaffTypes");
            DropTable("dbo.Staffs");
            DropTable("dbo.Sessions");
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Pages");
            DropTable("dbo.Grades");
            DropTable("dbo.Courses");
        }
    }
}
