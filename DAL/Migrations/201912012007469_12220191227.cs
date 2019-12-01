namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12220191227 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        GradeId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.GradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fees", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Fees", "GradeId", "dbo.Grades");
            DropIndex("dbo.Fees", new[] { "GradeId" });
            DropIndex("dbo.Fees", new[] { "StudentId" });
            DropTable("dbo.Fees");
        }
    }
}
