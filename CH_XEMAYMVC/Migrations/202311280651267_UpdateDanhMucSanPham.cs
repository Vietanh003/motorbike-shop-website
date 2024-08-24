namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDanhMucSanPham : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DanhMucSanPhams", "alias", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.DanhMucSanPhams", "Tieude", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.DanhMucSanPhams", "icon", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DanhMucSanPhams", "icon", c => c.String());
            AlterColumn("dbo.DanhMucSanPhams", "Tieude", c => c.String());
            DropColumn("dbo.DanhMucSanPhams", "alias");
        }
    }
}
