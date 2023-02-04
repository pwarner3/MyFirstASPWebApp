using Microsoft.AspNetCore.Mvc;
using MyFirstASPWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyFirstASPWebApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FanMail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FanMail(FanMailModel model)
        {
            return View();
        }
    }
}
