using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission5_ear69.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission5_ear69.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MoiveAppContext BlahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MoiveAppContext someName)
        {
            _logger = logger;
            BlahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Movie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Movie(MovieResponse ar)
        {
            if (ModelState.IsValid)
            {
                BlahContext.Add(ar);
                BlahContext.SaveChanges();
                return View("Confrim", ar);
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
