namespace Kiddo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailToRequisitador : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Requisitadors", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Requisitadors", "Email");
        }
    }
}
