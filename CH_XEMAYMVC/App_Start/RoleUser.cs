using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Text;
namespace CH_XEMAYMVC.App_Start
{
    public class RoleUser:AuthorizeAttribute
    {
        public int MaChucNang { get; set; }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var user = SessionConfig.GetUser();
            if (user == null)
            {
               //rt về trang đăng nhập
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new
                    {
                        controller = "User",
                        action = "Login",
                        area = "Admin"
                    }));
                return;
            }
            //check quyền
            if(MaChucNang!=0)
            {
                var check = new mapPhanQuyen().KiemTra(user.id,MaChucNang);
                if(check== false)
                {
                    filterContext.Result = new RedirectToRouteResult(
                   new RouteValueDictionary(new
                   {
                       controller = "Dashboard",
                       action = "LoiPhanQuyen",
                       area = "Admin"
                   }));
                    return;
                }
            }
            return;
        }
       
      
    }
}