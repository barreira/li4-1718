namespace Kiddo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequisitadorWithFK : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Requisitadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApplicationUserId = c.String(maxLength: 128),
                        Contact = c.String(),
                        Payment = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Requisitadors", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Requisitadors", new[] { "ApplicationUserId" });
            DropTable("dbo.Requisitadors");
        }
    }
}
