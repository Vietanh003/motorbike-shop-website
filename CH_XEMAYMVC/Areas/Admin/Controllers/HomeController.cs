using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangXeMay_Web.Models;
using CH_XEMAYMVC.App_Start;
namespace CH_XEMAYMVC.Areas.Admin.Controllers
{
    [RoleUser]
    public class HomeController : Controller
    {
        //
        // GET: /Admin/Home/
      
        public ActionResult Index()
        {
            Session["a"] = "a";
            TempData["sss"]="a";
           
            return View();
        }

	}
}