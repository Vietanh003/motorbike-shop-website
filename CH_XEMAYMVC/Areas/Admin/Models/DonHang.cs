//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CH_XEMAYMVC.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonHang
    {
        public DonHang()
        {
            this.ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }
    
        public long Id { get; set; }
        public string code { get; set; }
        public string tenkhachhang { get; set; }
        public string phone { get; set; }
        public string diachi { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public int soluong { get; set; }
        public System.DateTime ngaytao { get; set; }
        public string nguoitao { get; set; }
        public System.DateTime ngaysua { get; set; }
        public string nguoisua { get; set; }
    
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
