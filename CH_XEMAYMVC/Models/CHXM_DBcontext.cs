using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CuaHangXeMay_Web.Models
{
    public class CHXM_DBcontext: DbContext
    {
        public CHXM_DBcontext() : base("MyConnectionstring") { }
        public DbSet<NhanHieu> Nhanhieus { get; set; }
        public DbSet<XeMay> Xemays { get; set; }
        public DbSet<XuatXu> Xuatxus { get; set; }
        public DbSet<CaiDat> caidats { get; set; }
        public DbSet<ChiTietDonHang> chitietdonhangs { get; set; }
        public DbSet<DonHang> donhangs { get; set; }
        public DbSet<Dangky> DangKys { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<DanhMucSanPham> danhmucsanphams { get; set; }
        public DbSet<LienHe> lienhes { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<QuangCao> quangcaos { get; set; }
        public DbSet<TinTuc> tintucs { get; set; }
        public DbSet<ImageXe> imagexes { get; set; }
        public DbSet<Roles> roles { get; set; }
        public DbSet<NhanVien> nhanvien { get; set; }
        public DbSet<KhachHang> khachhang { get; set; }
        public DbSet<TaiKhoan> taikhoan { get; set; }
        public DbSet<UserRoles> Userrole { get; set; }
    }
}