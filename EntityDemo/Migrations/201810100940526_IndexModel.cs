namespace EntityDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IndexModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ModuleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Modules", t => t.ModuleId, cascadeDelete: true)
                .Index(t => t.ModuleId);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Module_Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Faculties", "ModuleId", "dbo.Modules");
            DropIndex("dbo.Faculties", new[] { "ModuleId" });
            DropTable("dbo.Modules");
            DropTable("dbo.Faculties");
        }
    }
}
