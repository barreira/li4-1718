namespace Kiddo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddService : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequisitadorId = c.Int(nullable: false),
                        BabysitterId = c.Int(nullable: false),
                        date = c.DateTime(nullable: false),
                        duration = c.Int(nullable: false),
                        location = c.String(nullable: false),
                        extra = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Babysitters", t => t.BabysitterId, cascadeDelete: true)
                .ForeignKey("dbo.Requisitadors", t => t.RequisitadorId, cascadeDelete: true)
                .Index(t => t.RequisitadorId)
                .Index(t => t.BabysitterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "RequisitadorId", "dbo.Requisitadors");
            DropForeignKey("dbo.Services", "BabysitterId", "dbo.Babysitters");
            DropIndex("dbo.Services", new[] { "BabysitterId" });
            DropIndex("dbo.Services", new[] { "RequisitadorId" });
            DropTable("dbo.Services");
        }
    }
}
