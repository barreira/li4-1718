namespace Kiddo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberChildrenToService : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "numberChildren", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "numberChildren");
        }
    }
}
