using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FancyWebsite.ViewModel;
using FancyWebsite.Models;

namespace FancyWebsite.ViewModel
{
    public class View_Model
    {
        public IEnumerable<Blog> _blog { get; set; }
        public IEnumerable<Blog> _blog2 { get; set; }
        public IEnumerable<Feature_Boxes> _Boxes { get; set; }
        public IEnumerable<Slider> _Slider { get; set; }
        public IEnumerable<Industry> _Industry { get; set; }
        public IEnumerable<Testimonials_Slider> _testimonials { get; set; }
        public IEnumerable<Service_Area> _Area { get; set; }
        public IEnumerable<Service_Area_Contents> _Contents { get; set; }
        public IEnumerable<Contact> _contact { get; set; }
    }
}