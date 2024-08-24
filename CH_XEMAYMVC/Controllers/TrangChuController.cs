using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangXeMay_Web.Models;
namespace CH_XEMAYMVC.Controllers
{
    public class TrangChuController : Controller
    {
        //
        // GET: /Home/
        CHXM_DBcontext db = new CHXM_DBcontext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SanPhamTheoLoai(int id)
        {
            List<XeMay> lstsanpham = db.Xemays.Where(x => x.Iddanhmuc == id).OrderBy(x => x.Tenxe).ToList();
            return View(lstsanpham);
        }
	}
}