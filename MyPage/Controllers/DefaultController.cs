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

        public PartialViewResult partialAboutSkill()
        {
            var values = db.Skills.ToList();
            return PartialView(values);
        }
        public PartialViewResult partialEducation()
        {
            var values = db.Educations.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialExperience()
        {
            var values = db.Experiences.ToList();
            return PartialView(values);
        }
        public PartialViewResult partialSkill()
        {
            var values = db.Skills.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialBlog()
        {
            var values = db.Projects.ToList();
            return PartialView(values);
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
        [HttpGet]
        public PartialViewResult partialContact()
        {
            var values = db.Contacts.ToList();
            return PartialView(values);
        }
        [HttpPost]
        public PartialViewResult partialContact(Contact p)
        {
            db.Contacts.Add(p);
            db.SaveChanges();
            return PartialView();
        }

        public PartialViewResult partialTestimonial()
        {
            var values = db.Referances.ToList();
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