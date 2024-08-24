using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangXeMay_Web.Models;
using CH_XEMAYMVC.App_Start;
namespace CH_XEMAYMVC.Areas.Admin.Controllers
{
    
    public class DanhMucController : Controller
    {
        CHXM_DBcontext db = new CHXM_DBcontext();
        //
        // GET: /Admin/DanhMuc/
        [RoleUser(MaChucNang=1)]
        public ActionResult Index()
        {
            var items = db.DanhMucs.ToList() ;
            return View(items);
        }
         [RoleUser(MaChucNang = 2)]
        public ActionResult Add()
        {
          
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(DanhMuc model)
        {
            if (ModelState.IsValid)
            {
                model.ngaytao = DateTime.Now;
                model.ngaysua = DateTime.Now;
                model.alias = CH_XEMAYMVC.Models.Common.Filter.FilterChar(model.Tieude);
                db.DanhMucs.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
           
        }
         [RoleUser(MaChucNang = 3)]
        public ActionResult Edit(int id)
        {
            var item = db.DanhMucs.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DanhMuc model)
        {
            if (ModelState.IsValid)
            {
                
                db.DanhMucs.Attach(model);
                model.ngaysua = DateTime.Now;
                model.alias = CH_XEMAYMVC.Models.Common.Filter.FilterChar(model.Tieude);
                db.Entry(model).Property(x => x.Tieude).IsModified = true;
                db.Entry(model).Property(x => x.mota).IsModified = true;
                db.Entry(model).Property(x => x.alias).IsModified = true;
                db.Entry(model).Property(x => x.seomota).IsModified = true;
                db.Entry(model).Property(x => x.seotukhoa).IsModified = true;
                db.Entry(model).Property(x => x.seotieude).IsModified = true;
                db.Entry(model).Property(x => x.position).IsModified = true;
                db.Entry(model).Property(x => x.ngaysua).IsModified = true;
                db.Entry(model).Property(x => x.nguoisua).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }
          [HttpPost]
          [RoleUser(MaChucNang = 4)]
        public ActionResult Delete(int id)
        {
            var item = db.DanhMucs.Find(id);
              if(item!=null)
              {
                 
                  db.DanhMucs.Remove(item);
                  db.SaveChanges();
                  return Json(new { success = true });
              }
              return Json(new { success = false });
        }
	}
}