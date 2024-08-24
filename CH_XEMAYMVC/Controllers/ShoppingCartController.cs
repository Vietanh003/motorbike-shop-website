using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;
using System.Web.Mvc;
using CuaHangXeMay_Web.Models;
using CH_XEMAYMVC.Models;
namespace CH_XEMAYMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        //
        // GET: /ShoppingCart/
        CHXM_DBcontext db = new CHXM_DBcontext();
        public ActionResult Index()
        {

            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null && cart.Items.Any())
            {
                ViewBag.checkcart = cart;
            }
            return View();
        }

        public ActionResult CheckOut()
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null && cart.Items.Any())
            {
                ViewBag.checkcart = cart;
            }
           return View();
            
        }
        public ActionResult CheckOutSuccess()
        {
            return View();
        }   
        public ActionResult Partial_CheckOut()
        {
            return PartialView();
        }
        public ActionResult Partial_Item_ThanhToan()
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null && cart.Items.Any())
            {
                return PartialView(cart.Items);
            }
            return PartialView();
        }
            
        public ActionResult Partial_Item_Cart()
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null && cart.Items.Any())
            {
                return PartialView(cart.Items);
            }
            return PartialView();
        }
       
        public ActionResult ShowCount()
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if(cart!=null)
            {
                return Json(new { count = cart.Items.Count }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { count = 0 },JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult AddToCart(int id, int quantity)
        {
            var code = new { Success = false, msg = "", code = -1 , count =0};
            var db  = new CHXM_DBcontext();
            var checkProduct = db.Xemays.FirstOrDefault(x => x.Maxe == id);
            if(checkProduct!=null)
            {
                ShoppingCart cart = Session["Cart"] as ShoppingCart;
                if (cart == null)
                {
                    cart = new ShoppingCart();
                    Session["Cart"] = cart;
                }

               

             
                  ShoppingCartItem Item = new ShoppingCartItem()
                    {
                        
                        ProductId=(int)checkProduct.Maxe,
                        ProductName= checkProduct.Tenxe,
                        Alias=checkProduct.alias,
                        //CategoryName= checkProduct.DanhMucSanPham.Tieude,
                        Quantity=quantity
                    };
                    if(checkProduct.ImageXe.FirstOrDefault(x=>x.isdefault)!=null)
                    {
                        Item.ProductImg= checkProduct.anh;
                    }
                    Item.Price = (decimal)checkProduct.Giaxe;
                    if(checkProduct.Giasale>0)
                    {
                        Item.Price = (decimal)checkProduct.Giasale; 
                    }
                    Item.TotalPrice = Item.Quantity * Item.Price;
                    cart.AddToCart(Item, quantity);
                    Session["Cart"] = cart;
                    code = new { Success = true, msg = "Thêm sản phẩm vào giỏ hàng thành công", code = 1 ,count=cart.Items.Count};
                
            }
            return Json(code);
        }
        [HttpPost]
        public ActionResult  Update (int id, int quantity)
        {
            ShoppingCart cart = (ShoppingCart)Session["Cart"];
            if (cart != null)
            {
                cart.UpdateQuantity(id,quantity);
                return Json(new { Success = true });
            }
            return Json(new { Success = false });
        }

        public ActionResult Delete(int id)
        {
           var code = new { Success = false, msg = "", code = -1, count = 0 };
           ShoppingCart cart = (ShoppingCart)Session["Cart"];
           if (cart != null)
           {

               var checkProduct = cart.Items.FirstOrDefault(x => x.ProductId == id);
               if(checkProduct!=null)
               {
                   cart.Remove(id);
                   code = new { Success = true, msg = "", code = 1, count = cart.Items.Count };
               }
           }
           return Json(code);
        }
        [HttpPost]
          public ActionResult DeleteAll()
          {
              ShoppingCart cart = (ShoppingCart)Session["Cart"];
              if (cart != null)
              {
                  cart.ClearCart();
                  return Json(new { Success = true });
              }
                return Json(new {Success = false});
          }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckOut(OrderViewModel req)
        {
            var code = new { Success = false, Code = -1 };
            if (ModelState.IsValid)
            {
                ShoppingCart cart = (ShoppingCart)Session["Cart"];
                if (cart != null)
                {
                    DonHang order = new DonHang();
                    order.tenkhachhang = req.CustomerName;
                    order.phone = req.Phone;
                    order.diachi = req.Address;
                    order.email = req.Email;
                    if (cart != null && cart.Items != null)
                    {
                        cart.Items.ForEach(x =>
                        {
                            if (x != null)
                            {
                                order.chitietdonhangs.Add(new ChiTietDonHang
                                {
                                    Maxe = x.ProductId,
                                    soluong = x.Quantity,
                                    Gia = x.Price
                                });
                            }
                        });
                    }


                    order.TongTien = cart.Items.Sum(x => (x.Price * x.Quantity));
                    order.TypePayment = req.TypePayment;
                    order.ngaytao = DateTime.Now;
                    order.ngaysua = DateTime.Now;
                    order.nguoisua = req.Phone;
                    Random rd = new Random();
                    order.code = "DH" + rd.Next(0, 9) + rd.Next(0, 9) + rd.Next(0, 9) + rd.Next(0, 9);
                    //order.E = req.CustomerName;
                   db.donhangs.Add(order);
                    db.SaveChanges();
                    //send mail cho khachs hang

                    cart.ClearCart();
                    return RedirectToAction("CheckOutSuccess");
                }
            }
            return Json(code);
        }
        
	}
}