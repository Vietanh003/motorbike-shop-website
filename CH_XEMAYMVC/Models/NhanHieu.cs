using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class NhanHieu
    {
        [Key]
        public long manhanhieu { get; set; }
        public string tennhanhieu { get; set; }
        public virtual ICollection<XeMay> xemays { get; set; }
    }
}