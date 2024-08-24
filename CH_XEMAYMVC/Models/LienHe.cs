using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class LienHe
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage="Tên không Được Để Trống")]
        [StringLength(150)]
        public string Name { get; set; }
        
        public string website { get; set; }
        [Required(ErrorMessage = "Email không Được Để Trống")]
        [StringLength(250)]
        public string email { get; set; }
        public string message { get; set; }
        public bool isread { get; set; }
        public DateTime ngaytao { get; set; }
        public string nguoitao { get; set; }
        public DateTime ngaysua { get; set; }
        public string nguoisua { get; set; }
        public virtual DanhMuc DanhMuc { get; set; }
    }
}