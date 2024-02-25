namespace MyPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experiences", "Location", c => c.String());
            AddColumn("dbo.Skills", "Color", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "Color");
            DropColumn("dbo.Experiences", "Location");
        }
    }
}
