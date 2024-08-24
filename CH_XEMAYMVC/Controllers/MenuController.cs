using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangXeMay_Web.Models;
namespace CH_XEMAYMVC.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Menu/
        CHXM_DBcontext db = new CHXM_DBcontext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MenuTop()
        {
            var items = db.DanhMucs.OrderBy(x => x.position).ToList();
            return PartialView("MenuTop", items);
        }
        public ActionResult MenuDanhMucSanPham()
        {
            var items = db.danhmucsanphams.ToList();
            return PartialView("MenuDanhMucSanPham", items);
        }
        
        public ActionResult MenuDiemThuHut()
        {
            var items = db.danhmucsanphams.ToList();
            return PartialView("MenuDiemThuHut", items);
        }
        public ActionResult MenuDanhMucTrai(int ?id)
        {
            if(id!=null)
            {
                ViewBag.Cateid = id;
            }
            var items = db.danhmucsanphams.ToList();
            return PartialView("MenuDanhMucTrai", items);
        }
        
	}
}