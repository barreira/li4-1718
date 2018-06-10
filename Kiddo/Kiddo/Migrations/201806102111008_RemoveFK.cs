namespace Kiddo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Babysitters", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Requisitadors", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Babysitters", new[] { "ApplicationUserId" });
            DropIndex("dbo.Requisitadors", new[] { "ApplicationUserId" });
            DropColumn("dbo.Babysitters", "ApplicationUserId");
            DropColumn("dbo.Requisitadors", "ApplicationUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Requisitadors", "ApplicationUserId", c => c.String(maxLength: 128));
            AddColumn("dbo.Babysitters", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Requisitadors", "ApplicationUserId");
            CreateIndex("dbo.Babysitters", "ApplicationUserId");
            AddForeignKey("dbo.Requisitadors", "ApplicationUserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Babysitters", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
    }
}
