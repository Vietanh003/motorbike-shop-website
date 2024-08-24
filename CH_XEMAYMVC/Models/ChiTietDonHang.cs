using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CuaHangXeMay_Web.Models
{
    public class ChiTietDonHang
    {
        [Key]
        [Column(Order = 0)]
        public long Idchitiet{ get; set; }
        [Required(ErrorMessage = "ID DonHang không Được Để Trống")]
        [Key]
        [Column(Order = 1)]
        public long Maxe { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public int soluong { get; set; }
        public virtual DonHang DonHang { get; set; }
        public virtual XeMay XeMay { get; set; }
    }
}