using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CuaHangXeMay_Web.Models
{
    public class XeMay
    {
        public XeMay()
        {
            this.ImageXe = new HashSet<ImageXe>();
            this.chitietdonhangs = new HashSet<ChiTietDonHang>();
        }
        [Key]
        public long Maxe { get; set; }
         [StringLength(150)]
         [Required(ErrorMessage = " Không Được Để Trống")]
        public string Tenxe { get; set; }
        public Nullable<decimal> Giaxe { get; set; }
        public Nullable<decimal> Giasale{ get; set; }
         [StringLength(150)]
        public string mota {get;set;}
         [AllowHtml]
        public string chitiet { get; set; }
         [StringLength(250)]
         [Required(ErrorMessage = " Không Được Để Trống")]
        public string anh { get; set; }
        public string soluong { get; set; }
        public bool IsHome { get; set; }
        public bool IsSale { get; set; }
        public bool IsFeature { get; set; }
        public bool IsHot { get; set; }
          [StringLength(250)]
        public string alias { get; set; }
          [StringLength(250)]
        public string Codesanpham { get; set; } 
        public long Iddanhmuc { get; set; }
        public bool IsActive { get; set; }
          public long maxuatxu { get; set; }
          public long manhanhieu { get; set; }
          [StringLength(250)]
          public string seotieude { get; set; }
          [StringLength(250)]
          public string seomota { get; set; }
          [StringLength(250)]
          public string seotukhoa { get; set; }

          public DateTime ngaytao { get; set; }
         [StringLength(150)]
          public string nguoitao { get; set; }
          public DateTime ngaysua { get; set; }
         [StringLength(150)]
          public string nguoisua { get; set; }
          public virtual DanhMucSanPham DanhMucSanPham { get; set; }
          public virtual  XuatXu XuatXu { get; set; }
          public virtual NhanHieu NhanHieu { get; set; }
          public virtual ICollection<ChiTietDonHang> chitietdonhangs { get; set; }
          public virtual ICollection<ImageXe> ImageXe { get; set; }
    }
}