using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class DanhMucSanPham
    {
       
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Tieude { get; set; }
        public string mota { get; set; }
     
        [StringLength(150)]
        public string alias { get; set; }
         [StringLength(250)]
        public string icon { get; set; }
         public string seotieude { get; set; }
         public string seomota { get; set; }
         public string seotukhoa { get; set; }
        public DateTime ngaytao { get; set; }
        public string nguoitao { get; set; }
        public DateTime ngaysua { get; set; }
        public string nguoisua { get; set; }
        public virtual ICollection<XeMay> xemays { get; set; }
    }
}