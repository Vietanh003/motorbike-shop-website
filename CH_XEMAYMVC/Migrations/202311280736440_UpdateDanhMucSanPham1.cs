namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDanhMucSanPham1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DanhMucSanPhams", "alias", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DanhMucSanPhams", "alias", c => c.String(nullable: false, maxLength: 150));
        }
    }
}
