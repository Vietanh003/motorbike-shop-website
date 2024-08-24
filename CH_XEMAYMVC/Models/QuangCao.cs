using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class QuangCao
    {
        [Key]
        public long Id { get; set; }
        public string Tieude { get; set; }
        public string mota { get; set; }
        public string image { get; set; }
        public int type { get; set; }
        public string link { get; set; }
        public DateTime ngaytao { get; set; }
        public string nguoitao { get; set; }
        public DateTime ngaysua { get; set; }
        public string nguoisua { get; set; }
    }
}