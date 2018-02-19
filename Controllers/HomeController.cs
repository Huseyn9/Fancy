using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FancyWebsite.ViewModel;
using FancyWebsite.Models;

namespace FancyWebsite.Controllers
{
    public class HomeController : Controller
    {
        FancyMagazineEntities db = new FancyMagazineEntities();
        public View_Model vm = new View_Model();
        public ActionResult Index()
        {
            vm._blog = db.Blogs.Take(3).ToList();
            vm._Boxes = db.Feature_Boxes.Take(3).ToList();
            vm._Slider = db.Sliders.Take(3).ToList();
            vm._blog2 = db.Blogs.Take(1).ToList();
            vm._Industry = db.Industries.Take(1).ToList();
            vm._testimonials = db.Testimonials_Slider.Take(3).ToList();
            vm._Area = db.Service_Area.Take(3).ToList();
            vm._Contents = db.Service_Area_Contents.Take(3).ToList();
            vm._contact = db.Contacts.Take(1).ToList();

            return View(vm);
        }
        public ActionResult Blog()
        {
            return View();
        }

    }
}