using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        // GET: ""/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        // POST: ""/
        [HttpPost("")]
        public IActionResult Result(string Name, string Location, string Language, string Comment)
        {

            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View();

        }

    }
}
