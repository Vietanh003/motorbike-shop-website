using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangXeMay_Web.Models;
using CH_XEMAYMVC.Models.Common;
using CH_XEMAYMVC.App_Start;
namespace CH_XEMAYMVC.Areas.Admin.Controllers
{
    public class DanhMucSanPhamController : Controller
    {
        //
        // GET: /Admin/DanhMucSanPham/
        CHXM_DBcontext db = new CHXM_DBcontext();
         [RoleUser(MaChucNang = 1)]
        public ActionResult Index()
        {
            var items = db.danhmucsanphams;
            return View(items);
        }
         [RoleUser(MaChucNang = 2)]
        public ActionResult Add()
        {
            var user = SessionConfig.GetUser();
            if (user == null)
            {
                return Redirect("/Admin/User/login");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(DanhMucSanPham model)
        {
            if (ModelState.IsValid)
            {
                model.ngaytao = DateTime.Now;
                model.ngaysua = DateTime.Now;
                model.alias = CH_XEMAYMVC.Models.Common.Filter.FilterChar(model.Tieude);
                db.danhmucsanphams.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }
	}
}