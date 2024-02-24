using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPage.Context;
using MyPage.Models.Entity;

namespace MyPage.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        MyPageContext db = new MyPageContext();
        public ActionResult Home()
        {
            return View();
        }

        public PartialViewResult partialCover()
        {
            return PartialView();
        }
        public PartialViewResult partialAbout()
        {
            var values = db.Abouts.ToList();
            return PartialView(values);
        }
        public PartialViewResult partialEducation()
        {
            return PartialView();
        }

        public PartialViewResult partialExperience()
        {
            return PartialView();
        }
        public PartialViewResult partialSkill()
        {
            return PartialView();
        }

        public PartialViewResult partialNavbar()
        {
            var values = db.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialNavbarSocial()
        {
            var values = db.Socials.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialHead()
        {
            return PartialView();
        }

        public PartialViewResult partialScript()
        {
            return PartialView();
        }
    }
}