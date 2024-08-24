using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class TaiKhoan
    {
        [Key]
        public long id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string HoVaTen { get; set; }
        public string sodienthoai { get; set; }
        public string hinhanh { get; set; }
        public virtual ICollection<UserRoles> userrole { get; set; }
    }
}