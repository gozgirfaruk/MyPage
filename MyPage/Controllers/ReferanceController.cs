using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPage.Repositories;
using MyPage.Models.Entity;

namespace MyPage.Controllers
{
    public class ReferanceController : Controller
    {
        // GET: Referance
        ReferanceRepository repo = new ReferanceRepository();
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
        public ActionResult Create(Referance p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Referance t = repo.TFind(x => x.ReferanceID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult Update(Referance p)
        {
            Referance t = repo.TFind(x => x.ReferanceID == p.ReferanceID);
            t.Name = p.Name;
            t.Title = p.Title;
            t.color = p.color;
            t.iconurl = p.iconurl;
            t.socialmedia = p.socialmedia;
            t.Description = p.Description;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            Referance t = repo.TFind(x => x.ReferanceID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }

    }
}