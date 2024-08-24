using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace CuaHangXeMay_Web.Models
{
    public class Roles
    {
        [Key]
        public long id { get; set; }
        public string name { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}