using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class Dangky
    {
        [Key]
        public long id { get; set; }
        [Required(ErrorMessage = "Email không Được Để Trống")]
        [StringLength(150)]
        public string Email { get; set; }
        public DateTime ngaytao { get; set; }
    }
}