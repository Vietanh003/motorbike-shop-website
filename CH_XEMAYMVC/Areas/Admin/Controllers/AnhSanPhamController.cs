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
    public class AnhSanPhamController : Controller
    {
        //
        // GET: /Admin/AnhXeMay/
        CHXM_DBcontext db = new CHXM_DBcontext();
        public ActionResult Index(int productId)
        {
            var items = db.imagexes.Where(x => x.idsanpham == productId).ToList();
            return View();
        }
	}
}