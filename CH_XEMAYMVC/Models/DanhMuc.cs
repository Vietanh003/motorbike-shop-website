using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CuaHangXeMay_Web.Models
{
    public class DanhMuc
    {
    public DanhMuc()
        {
            this.post = new HashSet<Post>();
        }
        [Key]
      
        public long Id { get; set; }
        [Required(ErrorMessage="Tên Danh Mục Không Được Để Trống")]
        [StringLength(150)]
        public string Tieude { get; set; }
           [StringLength(150)]
        public string mota { get; set; }
          [StringLength(150)]
           public string typecode { get; set; }
          public string link { get; set; }
           public string alias { get; set; }  
        public int position { get; set; }
        public string seotieude { get; set; }
        public string seomota { get; set; }
        public string seotukhoa { get; set; }
        public bool IsActive { get; set; }
        public DateTime ngaytao { get; set; }
        public string nguoitao { get; set; }
        public DateTime ngaysua { get; set; }
        public string nguoisua { get; set; }
        public virtual ICollection<TinTuc> tintucs { get; set; }
        public virtual ICollection<Post> post { get; set; }
        public virtual ICollection<LienHe> LienHe { get; set; }
    }
}