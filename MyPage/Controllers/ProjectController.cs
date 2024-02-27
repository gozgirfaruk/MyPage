using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPage.Repositories;
using MyPage.Models.Entity;

namespace MyPage.Controllers
{
    public class ProjectController : Controller
    {
        ProjectRepository repo = new ProjectRepository();
        // GET: Project
        public ActionResult Index()
        {
            var value = repo.TList();
            return View(value);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Project p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Project p = repo.TFind(x => x.ProjectID == id);
            return View(p);
        }

        [HttpPost]
        public ActionResult Update(Project p)
        {
            Project t = repo.TFind(x => x.ProjectID == p.ProjectID);
            t.Date = p.Date;
            t.Header = p.Header;
            t.ImageUrl = p.ImageUrl;
            t.Url = p.Url;
            t.Description = p.Description;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Project t = repo.TFind(x => x.ProjectID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
    }
}