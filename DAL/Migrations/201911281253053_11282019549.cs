namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11282019549 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StaffTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StaffTypeName = c.String(),
                        CreatedTime = c.DateTime(),
                        EditedTime = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        EditedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StaffTypes");
        }
    }
}
