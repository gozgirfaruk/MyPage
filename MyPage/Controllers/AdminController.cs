using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using MyPage.Models.Entity;
using MyPage.Repositories;

namespace MyPage.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        AdminRepository repo = new AdminRepository();
        public ActionResult Index()
        {
            var values = repo.TList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Admin p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            Admin t = repo.TFind(x => x.AdminID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult Update(Admin p)
        {
            Admin t = repo.TFind(x => x.AdminID == p.AdminID);
            t.Name = p.Name;
            t.Password = p.Password;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Log", "Login");
        }
    }
}