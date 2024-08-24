namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DanhMucs", "typecode", c => c.String(maxLength: 150));
            AddColumn("dbo.DanhMucs", "link", c => c.String());
            AlterColumn("dbo.XeMays", "Tenxe", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.XeMays", "Giaxe", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.XeMays", "anh", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.XeMays", "anh", c => c.String(maxLength: 250));
            AlterColumn("dbo.XeMays", "Giaxe", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.XeMays", "Tenxe", c => c.String(maxLength: 150));
            DropColumn("dbo.DanhMucs", "link");
            DropColumn("dbo.DanhMucs", "typecode");
        }
    }
}
