using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using KuVenkatCheckBox.Models;

namespace KuVenkatCheckBox.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            MVCDataModel db = new MVCDataModel();

            return View(db.Cities);
        }
        [HttpPost]
        public string Index(IEnumerable<City> cities)
        {
            if (cities.Count(x => x.IsSelected) == 0)
            {
                return "please select city";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You selected : ");

                foreach (var city in cities)
                {
                    if (city.IsSelected)
                    {
                        sb.Append(city.Name + ",");
                    }
                }
                return sb.ToString();
            }
        }
    }
}