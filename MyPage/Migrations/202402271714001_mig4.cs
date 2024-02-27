namespace MyPage.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Addresses", "Header");
            DropColumn("dbo.Addresses", "İmageUrl");
            DropColumn("dbo.Skills", "Description");
            DropColumn("dbo.Skills", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Skills", "Name", c => c.String());
            AddColumn("dbo.Skills", "Description", c => c.String());
            AddColumn("dbo.Addresses", "İmageUrl", c => c.String());
            AddColumn("dbo.Addresses", "Header", c => c.String());
        }
    }
}
