using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangXeMay_Web.Models;
namespace CH_XEMAYMVC.Controllers
{
    public class ProductsController : Controller
    {
        
        //
        // GET: /Products/
         CHXM_DBcontext db = new CHXM_DBcontext();
        public ActionResult Index(int ?id)
        {
            var items = db.Xemays.ToList();
            if(id!= null)
            {
                items = items.Where(x => x.Iddanhmuc==id).ToList();
            }
            ViewBag.CateId = id;
            var cate = db.danhmucsanphams.Find(id);
            if(cate!=null)
            {
                ViewBag.CateName = cate.Tieude;
            }
            return View(items);
        }
        public ActionResult ChiTietSanPham(string alias,int id)
        {
            var items = db.Xemays.Find(id);
            
            return View(items);
        }
        public ActionResult Partial_Item()
        {
            var items = db.Xemays.Where(x=>x.IsActive).Take(12).ToList();
            return PartialView(items);
        }
        public ActionResult Partial_ItemIsHot()
        {
            var items = db.Xemays.Where(x => x.IsHot&&x.IsActive).Take(12).ToList();
            return PartialView(items);
        }
       
	}
}