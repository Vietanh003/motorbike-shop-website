using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class ImageXe
    {
        [Key]
        public long id { get; set; }
        public long idsanpham { get; set; }
        public string image { get; set; }
        public bool isdefault { get; set; }
        public virtual XeMay Xemay { get; set; }
    }
}