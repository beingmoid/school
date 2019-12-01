namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12220191204 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserSelectedTypes", "UserID", "dbo.Users");
            DropForeignKey("dbo.UserSelectedTypes", "UserTypeID", "dbo.UserTypes");
            DropIndex("dbo.UserSelectedTypes", new[] { "UserID" });
            DropIndex("dbo.UserSelectedTypes", new[] { "UserTypeID" });
            AlterColumn("dbo.Courses", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Courses", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Courses", "EditedBy", c => c.Int());
            AlterColumn("dbo.Grades", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Grades", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Grades", "EditedBy", c => c.Int());
            AlterColumn("dbo.Pages", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Pages", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Pages", "EditedBy", c => c.Int());
            AlterColumn("dbo.UserRoles", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.UserRoles", "CreatedBy", c => c.Int());
            AlterColumn("dbo.UserRoles", "EditedBy", c => c.Int());
            AlterColumn("dbo.Users", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Users", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Users", "EditedBy", c => c.Int());
            AlterColumn("dbo.Sessions", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Sessions", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Sessions", "EditedBy", c => c.Int());
            AlterColumn("dbo.UserTypes", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.UserTypes", "CreatedBy", c => c.Int());
            AlterColumn("dbo.UserTypes", "EditedBy", c => c.Int());
            AlterColumn("dbo.Staffs", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Staffs", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Staffs", "EditedBy", c => c.Int());
            AlterColumn("dbo.StaffTypes", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.StaffTypes", "CreatedBy", c => c.Int());
            AlterColumn("dbo.StaffTypes", "EditedBy", c => c.Int());
            AlterColumn("dbo.Students", "EditedTime", c => c.DateTime());
            AlterColumn("dbo.Students", "CreatedBy", c => c.Int());
            AlterColumn("dbo.Students", "EditedBy", c => c.Int());
            DropTable("dbo.UserSelectedTypes");
        }
        
        public override void Down()
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
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Students", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.StaffTypes", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.StaffTypes", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.StaffTypes", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Staffs", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Staffs", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Staffs", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserTypes", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.UserTypes", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.UserTypes", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Sessions", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sessions", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Sessions", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.UserRoles", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.UserRoles", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.UserRoles", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Pages", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Pages", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Pages", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Grades", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Grades", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Grades", "EditedTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "EditedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "CreatedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "EditedTime", c => c.DateTime(nullable: false));
            CreateIndex("dbo.UserSelectedTypes", "UserTypeID");
            CreateIndex("dbo.UserSelectedTypes", "UserID");
            AddForeignKey("dbo.UserSelectedTypes", "UserTypeID", "dbo.UserTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserSelectedTypes", "UserID", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
