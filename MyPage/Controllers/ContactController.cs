using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPage.Repositories;
using MyPage.Models.Entity;
using System.Web.Security;

namespace MyPage.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactRepository repo = new ContactRepository();
        public ActionResult Index()
        {
            var values = repo.TList();
            return View(values);
        }
        [HttpGet]
        public ActionResult Bring(int id)
        {
            var values = repo.TFind(x => x.ContactID == id);
            ViewBag.c = values.eMail.ToString();
            return View(values);
        }
        [HttpPost]
        public ActionResult Bring(Contact p)
        {
            
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            Contact t = repo.TFind(x => x.ContactID == id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }


        
    }
}