namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12220191230 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gradeid = c.Int(nullable: false),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(),
                        CreatedBy = c.Int(),
                        EditedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.Gradeid, cascadeDelete: true)
                .Index(t => t.Gradeid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sections", "Gradeid", "dbo.Grades");
            DropIndex("dbo.Sections", new[] { "Gradeid" });
            DropTable("dbo.Sections");
        }
    }
}
