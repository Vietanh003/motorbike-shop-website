namespace CH_XEMAYMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class taikhoan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        idkhachhang = c.Long(nullable: false, identity: true),
                        tenkhachhhang = c.String(),
                        SoDienThoai = c.String(),
                        DiaChi = c.String(),
                        NamSinh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idkhachhang);
            
            CreateTable(
                "dbo.TaiKhoans",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        HoVaTen = c.String(),
                        sodienthoai = c.String(),
                        hinhanh = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaiKhoans");
            DropTable("dbo.KhachHangs");
        }
    }
}
