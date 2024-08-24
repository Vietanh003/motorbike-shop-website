using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CH_XEMAYMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "TrangChu",
               url: "Trang Chu",
               defaults: new { controller = "Home", action = "Index", alias = UrlParameter.Optional }

           );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "ThanhToan",
               url: "thanh-toan",
               defaults: new { controller = "ShoppingCart", action = "CheckOut", alias = UrlParameter.Optional }

           );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "LienHe",
               url: "Lien He",
               defaults: new { controller = "LienHe", action = "Index", alias = UrlParameter.Optional }

           );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "GioHang",
               url: "gio-hang",
               defaults: new { controller = "ShoppingCart", action = "Index", alias = UrlParameter.Optional }

           );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "DanhMucSanPham",
               url: "San-Pham",
               defaults: new { controller = "Products", action = "Index", alias = UrlParameter.Optional }

           );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "ChitietSanPham",
               url: "chi-tiet/{alias}-p{id}",
               defaults: new { controller = "Products", action = "ChiTietSanPham", alias = UrlParameter.Optional }

           );
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "SanPham",
               url: "danh-muc-san-pham/{alias}-{id}",
               defaults: new { controller = "Products", action = "Index", alias = UrlParameter.Optional }

           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
