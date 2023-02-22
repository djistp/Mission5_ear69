using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MoiveAppContext MaContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MoiveAppContext someName)
        {
            _logger = logger;
            MaContext = someName;
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
            ViewBag.Categories = MaContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Movie(MovieResponse ar)
        {
            if (ModelState.IsValid)
            {
                MaContext.Add(ar);
                MaContext.SaveChanges();
                return View("Confrim", ar);
            }
            else
            {
                ViewBag.Categories = MaContext.Categories.ToList();
                return View();
            }
        }

        [HttpGet]
        public IActionResult Waitlist ()
        {
            var applications = MaContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Category.CategoryName)
                .ToList();
            return View(applications);
        }


        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = MaContext.Categories.ToList();
            var application = MaContext.Responses.Single(x => x.MovieId == movieid);
            return View("Movie",application);

        }

        [HttpPost]
        public IActionResult Edit(MovieResponse ar)
        {

            
            MaContext.Update(ar);
            MaContext.SaveChanges();

            return RedirectToAction("Waitlist");
        }

        [HttpGet]
        public IActionResult Delete(int MovieId)
        {
            var movie = MaContext.Responses.Single(x => x.MovieId == MovieId);
            return View(movie);
        }

        [HttpPost]

        public IActionResult Delete(MovieResponse ar)

        {
            MaContext.Responses.Remove(ar);
            MaContext.SaveChanges();
            return RedirectToAction("Waitlist");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
