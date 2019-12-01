namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _12220191226 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Grades", "Gradefess", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Grades", "Gradefess");
        }
    }
}
