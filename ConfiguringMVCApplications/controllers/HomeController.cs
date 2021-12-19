using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfiguringMVCApplications.controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View("ContactPage");
        }

        public ViewResult Privacy()
        {
            return View();
        }

        public ViewResult Message()
        {
            return View();
        }
    }

}
