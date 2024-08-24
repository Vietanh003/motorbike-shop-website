namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class XeMay1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.XeMays", "Giaxe", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.XeMays", "Giaxe", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
