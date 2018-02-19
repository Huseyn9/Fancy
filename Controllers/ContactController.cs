using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FancyWebsite.Models;
using FancyWebsite.ViewModel;
namespace FancyWebsite.Controllers
{
    public class ContactController : Controller
    {
        FancyMagazineEntities db = new FancyMagazineEntities();
        View_Model vm = new View_Model();
        // GET: Contact
        public ActionResult Index()
        {
            vm._contact = db.Contacts.Take(1).ToList();
            return View(vm);
        }
    }
}