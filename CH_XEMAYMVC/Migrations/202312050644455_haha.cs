namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class haha : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DonHangs", "email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DonHangs", "email");
        }
    }
}
