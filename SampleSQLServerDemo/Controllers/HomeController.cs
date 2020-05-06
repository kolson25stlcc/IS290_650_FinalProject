using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleDemo.Models;

namespace SampleDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //ViewBag.Name = "Mary"; 
            //ViewBag.FV = 99999.99;
            ViewBag.FV = 0;
            return View();
        }
        

    }
}