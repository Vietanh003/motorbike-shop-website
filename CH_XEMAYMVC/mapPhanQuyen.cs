using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangXeMay_Web.Models;
namespace CH_XEMAYMVC
{
    public class mapPhanQuyen
    {
        CHXM_DBcontext db = new CHXM_DBcontext();
        public string mesage = "";
        public bool KiemTra(long idtaikhoan, long idchucnang )
        {
            var dem = db.Userrole.Count(x => x.id == idtaikhoan & x.RoleId == idchucnang);
                if(dem>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
    }
}