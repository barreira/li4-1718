namespace Kiddo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBabysitterFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Babysitters", "ApplicationUserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Babysitters", "ApplicationUserId");
            AddForeignKey("dbo.Babysitters", "ApplicationUserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Babysitters", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.Babysitters", new[] { "ApplicationUserId" });
            DropColumn("dbo.Babysitters", "ApplicationUserId");
        }
    }
}
