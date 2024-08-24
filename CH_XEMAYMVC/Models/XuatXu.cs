using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CuaHangXeMay_Web.Models
{
    public class XuatXu
    {
        [Key]
        public long maxuatxu { get; set; }
        public string tenxuatxu { get; set; }
        public virtual ICollection<XeMay> xemays{ get; set; }
    }
}