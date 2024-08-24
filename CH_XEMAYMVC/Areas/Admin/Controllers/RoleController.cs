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
    public class RoleController : Controller
    {
        //
        // GET: /Admin/Role/
        
        CHXM_DBcontext db = new CHXM_DBcontext();
         [RoleUser(MaChucNang = 1)]
        public ActionResult Index()
        {   
            var items = db.roles.ToList();
            return View(items);
        }
	}
}