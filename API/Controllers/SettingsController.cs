using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult InitGrid(string difficulty)
        {
            Console.WriteLine($"Difficulty : {difficulty}");
            return Json("OK");
        }
    }
}
