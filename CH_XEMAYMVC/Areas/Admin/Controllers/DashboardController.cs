using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CH_XEMAYMVC.Models;
using CH_XEMAYMVC.App_Start;
namespace CH_XEMAYMVC.Areas.Admin.Controllers
{
         [RoleUser]
    public class DashboardController : Controller
    {
        //
        // GET: /Admin/Dashboard/
    
        public ActionResult Index()
        {
            
            return View(new mapTaiKhoan().DanhSach());
        }
        public ActionResult LoiPhanQuyen()
        {

            return View();
        }
	}
}