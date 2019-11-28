namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11282019552 : DbMigration
    {
        public override void Up()
        {
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
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.StaffTypes", t => t.StaffTypeId, cascadeDelete: true)
                .Index(t => t.StaffTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Staffs", "StaffTypeId", "dbo.StaffTypes");
            DropIndex("dbo.Staffs", new[] { "StaffTypeId" });
            DropTable("dbo.Staffs");
        }
    }
}
