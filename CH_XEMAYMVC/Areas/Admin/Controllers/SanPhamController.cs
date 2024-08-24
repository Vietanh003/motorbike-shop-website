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
   
    public class SanPhamController : Controller
    {
        CHXM_DBcontext db = new CHXM_DBcontext();
        //
        // GET: /Admin/SanPham/
         [RoleUser(MaChucNang = 1)]
        public ActionResult Index(int? page, string searchtext)
        {
            IEnumerable<XeMay> items = db.Xemays.OrderByDescending(x => x.Maxe);
            var pageSize = 7;
            if (page == null)
            {
                page = 1;
            }
          
            if (!string.IsNullOrEmpty(searchtext))
            {
                items = items.Where(x => x.alias.Contains(searchtext) || x.Tenxe.Contains(searchtext)).ToList();
            }
            var pageIndex = page.HasValue ? Convert.ToInt32(page) : 1;
            items = items.ToPagedList(pageIndex, pageSize);
            ViewBag.PageSize = pageSize;
            ViewBag.Page = page;
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
            ViewBag.XuatXu = new SelectList(db.Xuatxus.ToList(), "maxuatxu", "tenxuatxu");
            ViewBag.NhanHieu = new SelectList(db.Nhanhieus.ToList(), "manhanhieu", "tennhanhieu");
            ViewBag.DanhMucSanPham = new SelectList(db.danhmucsanphams.ToList(), "Id", "TieuDe");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(XeMay model, List<string> Images, List<int> rDefault)
        {
            ViewBag.XuatXu = new SelectList(db.Xuatxus.ToList(), "maxuatxu", "tenxuatxu");
            ViewBag.NhanHieu = new SelectList(db.Nhanhieus.ToList(), "manhanhieu", "tennhanhieu");
            ViewBag.DanhMucSanPham = new SelectList(db.danhmucsanphams.ToList(), "Id", "TieuDe");
            //if (ModelState.IsValid)
            //{
                if(Images!=null&&Images.Count>0)
                {
                 
                    for(int i =0; i<Images.Count;i++)
                    {
                        if(i+1==rDefault[0])
                        {
                            model.anh = Images[i];
                            model.ImageXe.Add(new ImageXe{
                               idsanpham=model.Maxe,
                                image=Images[i],
                                isdefault=true
                            });
                        }
                        else
                        {
                              model.ImageXe.Add(new ImageXe{
                                  idsanpham = model.Maxe,
                                image=Images[i],
                                isdefault=false
                              });
                        }
                    }
                }
                model.ngaytao = DateTime.Now;
                model.ngaysua = DateTime.Now;
      
                if(string.IsNullOrEmpty(model.seotieude))
                {
                    model.seotieude = model.Tenxe;
                }
                if (string.IsNullOrEmpty(model.alias))
                {
                    model.alias = CH_XEMAYMVC.Models.Common.Filter.FilterChar(model.Tenxe);
                }
                db.Xemays.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            
           

        }
         [RoleUser(MaChucNang = 3)]
        public ActionResult Edit(int id)
        {
            ViewBag.XuatXu = new SelectList(db.Xuatxus.ToList(), "maxuatxu", "tenxuatxu");
            ViewBag.NhanHieu = new SelectList(db.Nhanhieus.ToList(), "manhanhieu", "tennhanhieu");
            ViewBag.DanhMucSanPham = new SelectList(db.danhmucsanphams.ToList(), "Id", "TieuDe");
            var item = db.Xemays.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(XeMay model)
        {
            ViewBag.XuatXu = new SelectList(db.Xuatxus.ToList(), "maxuatxu", "tenxuatxu");
            ViewBag.NhanHieu = new SelectList(db.Nhanhieus.ToList(), "manhanhieu", "tennhanhieu");
            ViewBag.DanhMucSanPham = new SelectList(db.danhmucsanphams.ToList(), "Id", "TieuDe");
                model.ngaysua = DateTime.Now;
                model.alias = CH_XEMAYMVC.Models.Common.Filter.FilterChar(model.Tenxe);
                db.Xemays.Attach(model);
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
    
        }
         [RoleUser(MaChucNang = 4)]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Xemays.Find(id);
            if (item != null)
            {

                db.Xemays.Remove(item);
                db.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
         [RoleUser(MaChucNang = 3)]
        [HttpPost]
        public ActionResult IsActive(int id)
        {
           
                var item = db.Xemays.Find(id);
                if (item != null)
                {
                    item.IsActive = !item.IsActive;
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { success = true, isActive = item.IsActive });
                }
                return Json(new { success = false, error = "Item not found" });
         
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
                        var obj = db.Xemays.Find(Convert.ToInt32(item));
                        db.Xemays.Remove(obj);
                        db.SaveChanges();

                    }
                }
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
	}
}