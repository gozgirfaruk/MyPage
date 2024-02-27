using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPage.Models.Entity;
using MyPage.Context;
using System.Web.Security;

namespace MyPage.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Log()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Log(Admin p)
        {
            MyPageContext db = new MyPageContext();
            var UserInfo = db.Admins.FirstOrDefault(x => x.Name == p.Name && x.Password == p.Password);

            if(UserInfo!=null)
            {
                FormsAuthentication.SetAuthCookie(UserInfo.Name, false);
                Session["Name"] = UserInfo.Name.ToString();
                return RedirectToAction("Index", "About");
            }

            else
            {
                return RedirectToAction("Log", "Login");
            }
            
        }
    }
}