using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CuaHangXeMay_Web.Models;
namespace CH_XEMAYMVC.App_Start
{
    public static class SessionConfig
    {
        //luu user
        public static void SetUser(TaiKhoan User)
        {

            HttpContext.Current.Session["user"] = User;
        }
        public static TaiKhoan GetUser()
        {
            //luu vaof session
            return (TaiKhoan)HttpContext.Current.Session["user"];
        }
            
    }
}