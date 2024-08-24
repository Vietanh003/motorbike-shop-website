using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class CaiDat
    {
        [Key]
        public long settingkey{ get; set; }
        public string settingvalue { get; set; }
        public string settingmota { get; set; }
    }
}