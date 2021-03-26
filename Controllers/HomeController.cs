using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {

        private MovieDbContext context { get; set; }

        public HomeController(MovieDbContext con)
        {
            context = con;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Movie m)
        {
            if (ModelState.IsValid)
            {
                context.Movies.Add(m);
                context.SaveChanges();
                return RedirectToAction("MovieList");
            }
            else
                return View();     
        }

        [HttpPost]
        public IActionResult Edit(Movie m)
        {
            context.Movies.Remove(m);
            context.SaveChanges();
           
            return RedirectToAction("MovieForm");
        }

        [HttpPost]
        public IActionResult Delete(Movie m)
        {
            context.Movies.Remove(m);
            context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        public IActionResult MovieList()
        {
            return View(context.Movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
