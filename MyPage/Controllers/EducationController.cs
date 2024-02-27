using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPage.Repositories;
using MyPage.Models.Entity;

namespace MyPage.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        EducationRepository repo = new EducationRepository();
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
        public ActionResult Create(Education p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Education edu = repo.TFind(x => x.EducationID == id);
            return View(edu);
        }

        [HttpPost]
        public ActionResult Update(Education p)
        {
            Education edu = repo.TFind(x => x.EducationID == p.EducationID);
            edu.Header = p.Header;
            edu.SchoolName = p.SchoolName;
            edu.Degree = p.Degree;
            edu.Description = p.Description;
            repo.TUpdate(edu);
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            Education edu = repo.TFind(x => x.EducationID == id);
            repo.TDelete(edu);
            return RedirectToAction("Index");
        }

    }
}