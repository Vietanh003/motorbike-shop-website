namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class XeMay : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ImageXes", "idsanpham", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ImageXes", "idsanpham", c => c.Int(nullable: false));
        }
    }
}
