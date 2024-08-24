
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangXeMay_Web.Models;
namespace CH_XEMAYMVC.Models
{
    public class mapTaiKhoan
    {
        CHXM_DBcontext db = new CHXM_DBcontext();
        public TaiKhoan TimKiem(string usernames, string password)
        {
            var user = db.taikhoan.Where(x => x.UserName == usernames & x.Password == password).ToList();
            if (user.Count > 0)
            {
                return user[0];
            }
            else
            {
                return null;
            }
        }
        public List<TaiKhoan> DanhSach()
        {
            var user = db.taikhoan.ToList();
            return user;

        }
        public bool Themmoi(TaiKhoan tk)
        {
            try
            {
                db.taikhoan.Add(tk);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}