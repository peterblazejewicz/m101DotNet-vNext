using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace SystemCheck.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          var i = 0;
          for (var bit = 0; bit < 32; bit++)
          {
              i |= bit << bit;
          }
          ViewBag.Message = i.ToString();
          return View();
        }
    }
}