using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class NhanVien
    {
        [Key]
        public long idnhanvien { get; set; }
        public string tennhanvien { get; set; }
        public string SDT { get; set; }
        public string Username { get; set; }
        public string password { get; set; }
      
    }
}