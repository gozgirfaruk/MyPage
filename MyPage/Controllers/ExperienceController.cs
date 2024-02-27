using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPage.Repositories;
using MyPage.Models.Entity;

namespace MyPage.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        ExperienceRepository repo = new ExperienceRepository();
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
        public ActionResult Create(Experience p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Experience exp = repo.TFind(x => x.ExperienceID == id);
            repo.TDelete(exp);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Experience exp = repo.TFind(x => x.ExperienceID == id);
            return View(exp);
        }

        [HttpPost]
        public ActionResult Update (Experience p)
        {
            Experience exp = repo.TFind(x => x.ExperienceID == p.ExperienceID);
            exp.Name = p.Name;
            exp.Year = p.Year;
            exp.Location = p.Location;
            exp.Description = p.Description;
            repo.TUpdate(exp);
            return RedirectToAction("Index");
        }
    }
}