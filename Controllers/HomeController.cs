using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dojo.Models;

namespace dojo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost("Add")]
        public IActionResult Add(Survey newSurvey)
        {
            Console.WriteLine($"Name:{newSurvey.Name}");
            ViewBag.Name =newSurvey.Name;
            ViewBag.Location =newSurvey.Location;
            ViewBag.Language =newSurvey.Language;
            ViewBag.Comment =newSurvey.Comment;

            return View("Index");
        }
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
