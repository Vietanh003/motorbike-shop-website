using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangXeMay_Web.Models;
namespace CH_XEMAYMVC.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        CHXM_DBcontext db = new CHXM_DBcontext();
        public ActionResult Index(int ?page)
        {
            var items = db.donhangs.OrderByDescending(x => x.ngaytao).ToList();
            
            return View();
        }
	}
}