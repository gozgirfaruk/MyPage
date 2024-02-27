using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPage.Repositories;
using MyPage.Models.Entity;
using MyPage.Context;


namespace MyPage.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutRepository repo = new AboutRepository();
        public ActionResult Index()
        {
            var values = repo.TList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AboutAdd()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AboutAdd(About p)
        {

            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            About t = repo.TFind(x => x.AboutID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            About t = repo.TFind(x => x.AboutID == id);
            return View(t);
        }

        [HttpPost]
        public ActionResult Update(About p)
        {
            About t = repo.TFind(x => x.AboutID == p.AboutID);
            t.Header = p.Header;
            t.Title = p.Title;
            t.NameSurname = p.NameSurname;
            t.ImageUrl = p.ImageUrl;
            t.ImageUrlTwo = p.ImageUrlTwo;
            t.Description = p.Description;
            t.DescriptionSmall = p.DescriptionSmall;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}