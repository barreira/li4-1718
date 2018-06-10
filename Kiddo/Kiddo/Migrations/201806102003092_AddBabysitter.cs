namespace Kiddo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBabysitter : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Babysitters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Photo = c.String(),
                        City = c.String(),
                        PricePerHour = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Babysitters");
        }
    }
}
