using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CuaHangXeMay_Web.Models
{
    public class UserRoles
    {
        [Key]
        [Column(Order = 0)]
        public long id { get; set; }
        [Required(ErrorMessage = "Order không được để trống")]
        [Key]
        [Column(Order = 1)]
        public long RoleId { get; set; }
        public virtual TaiKhoan taikhoan { get; set; }
        public virtual Roles Role { get; set; }

    }
}