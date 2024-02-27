using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPage.Models.Entity;
using MyPage.Repositories;


namespace MyPage.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        SkillRepository repo = new SkillRepository();
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
        public ActionResult Create(Skill p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Skill t = repo.TFind(x => x.SkillID == id);
            return View("Update", t);
        }

        [HttpPost]
        public ActionResult Update(Skill p)
        {
            Skill t = repo.TFind(x => x.SkillID == p.SkillID);
            t.Header = p.Header;
            t.Point = p.Point;
            t.Color = p.Color;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Skill t = repo.TFind(x => x.SkillID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
    }
}