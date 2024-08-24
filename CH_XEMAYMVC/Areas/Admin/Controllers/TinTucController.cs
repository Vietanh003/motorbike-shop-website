using System;
using PagedList;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CuaHangXeMay_Web.Models;
using CH_XEMAYMVC.App_Start;
namespace CH_XEMAYMVC.Areas.Admin.Controllers
{
     [RoleUser]
    public class TinTucController : Controller
    {
        //
        // GET: /Admin/TinTuc/
        CHXM_DBcontext db = new CHXM_DBcontext();
         [RoleUser(MaChucNang = 1)]
        public ActionResult Index(string searchtext, int? page)
        {
            var pageSize = 5;
            if(page==null)
            {
                page = 1;
            }
       IEnumerable<TinTuc>items= db.tintucs.OrderByDescending(x=>x.Id);
       if (!string.IsNullOrEmpty(searchtext))
            {
                items = items.Where(x => x.alias.Contains(searchtext) || x.Tieude.Contains(searchtext)).ToList();
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page):1;
             items= items.ToPagedList(pageIndex,pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
            return View(items);
        }
          [RoleUser(MaChucNang = 2)]
        public ActionResult Add()
        {
           
            return View();
        }
         
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Add(TinTuc model)
        {
            if (ModelState.IsValid)
            {
                model.ngaytao = DateTime.Now;
                model.Iddanhmuc = 10;
                model.ngaysua = DateTime.Now;
                model.alias = CH_XEMAYMVC.Models.Common.Filter.FilterChar(model.Tieude);
                db.tintucs.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }
          [RoleUser(MaChucNang = 3)]
        public ActionResult Edit(int id)
        {
            var item = db.tintucs.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TinTuc model)
        {
            if (ModelState.IsValid)
            {
                model.ngaysua = DateTime.Now;
                model.alias = CH_XEMAYMVC.Models.Common.Filter.FilterChar(model.Tieude);
                db.tintucs.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.tintucs.Find(id);
            if (item != null)
            {

                db.tintucs.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
          [RoleUser(MaChucNang = 3)]
        [HttpPost]
        public ActionResult IsActive(int id)
        {
            try
            {
                var item = db.tintucs.Find(id);
                if (item != null)
                {
                    item.IsActive = !item.IsActive;
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { success = true, isActive = item.IsActive });
                }
                return Json(new { success = false, error = "Item not found" });
            }
            catch (Exception ex)
            {
              
                return Json(new { success = false, error = ex.Message });
            }
        }
          [RoleUser(MaChucNang = 4)]
        [HttpPost]
        public ActionResult DeleteAll(string ids)
        {
            if (!string.IsNullOrEmpty(ids))
            {
                var items = ids.Split(',');
                if (items != null && items.Any())
                {
                    foreach (var item in items)
                    {
                        var obj = db.tintucs.Find(Convert.ToInt32(item));
                        db.tintucs.Remove(obj);
                        db.SaveChanges();

                    }
                }
                 return Json(new { success = true});
            }
            return Json(new { success = false });
        }
	}
}