using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class KhachHang
    {
        [Key]
        public long idkhachhang { get; set; }
        public string tenkhachhhang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public Int32 NamSinh { get; set; }
      
    }
}