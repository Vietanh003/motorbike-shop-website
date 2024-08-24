using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class DonHang
    {
        public DonHang()
        {
            this.chitietdonhangs = new HashSet<ChiTietDonHang>();
        }
        [Key]
        public long Id { get; set; }
        public string code { get; set; }
        [Required(ErrorMessage = "Tên không Được Để Trống")]
        [StringLength(150)]
        public string tenkhachhang { get; set; }
        [Required(ErrorMessage = "Tên không Được Để Trống")]
        [StringLength(20)]
        public string phone { get; set; }
        [Required(ErrorMessage = "Tên không Được Để Trống")]
        [StringLength(1000)]
        public string diachi { get; set; }
        public string email { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public int soluong { get; set; }
        public int TypePayment { get; set; }
        public DateTime ngaytao { get; set; }
        public string nguoitao { get; set; }
        public DateTime ngaysua { get; set; }
        public string nguoisua { get; set; }
        public virtual ICollection<ChiTietDonHang> chitietdonhangs { get; set; }
    }
}