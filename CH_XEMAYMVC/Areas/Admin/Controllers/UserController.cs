using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CH_XEMAYMVC.Models;
using CuaHangXeMay_Web.Models;
using CH_XEMAYMVC.App_Start;
namespace CH_XEMAYMVC.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
    
        CHXM_DBcontext db = new CHXM_DBcontext();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string name ,string pass)
        {
            mapTaiKhoan map = new mapTaiKhoan();
            var user = map.TimKiem(name, pass);
            if (user != null)
            {
                SessionConfig.SetUser(user);
                var us = SessionConfig.GetUser();
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }
            ViewBag.error = "Tên Đăng Nhập Hoặc Mật Khẩu Không Đúng";
            return View();
        }
        public ActionResult Logout()
        {
           SessionConfig.SetUser(null);
                return RedirectToAction("Login", "User", new { area = "Admin" });
        }

        public ActionResult DangKy()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(TaiKhoan model)
        {
            mapTaiKhoan map = new mapTaiKhoan();
            if (map.Themmoi(model) == true)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View(model);
            }
        }
	}
}