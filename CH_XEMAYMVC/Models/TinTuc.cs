using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace CuaHangXeMay_Web.Models
{
    public class TinTuc
    {
        public long Id { get; set; }
        public string Tieude { get; set; }
        public long Iddanhmuc { get; set; }
        public string mota { get; set; }
        [AllowHtml]
        public string chitiet { get; set; }
        public string image { get; set; }
        public string alias { get; set; } 
          public string seotieude { get; set; }
        public string seomota { get; set; }
        public string seotukhoa { get; set; }
        public DateTime ngaytao { get; set; }
        public string nguoitao { get; set; }
        public DateTime ngaysua { get; set; }
        public string nguoisua { get; set; }
        public bool IsActive { get; set; }
        public virtual DanhMuc DanhMuc { get; set; }
    }
}