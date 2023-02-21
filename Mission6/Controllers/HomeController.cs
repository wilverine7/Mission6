using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        
        private MovieCollectionContext _MovieContext { get; set; }
        public HomeController( MovieCollectionContext context)
        {
            
            _MovieContext = context;
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
        public IActionResult AddMovie()
        {

            ViewBag.Categories = _MovieContext.Categories.ToList();
            return View(new ApplicationResponse());
        }
        [HttpPost]
        public IActionResult AddMovie(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                _MovieContext.Add(ar);
                _MovieContext.SaveChanges();
                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = _MovieContext.Categories.ToList();

                return View();
            }
        }

        public IActionResult ViewCollection()
        {
            var applications = _MovieContext.Responses
                .Include(x => x.Category)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _MovieContext.Categories.ToList();

            var movie = _MovieContext.Responses.Single(x => x.MovieId == id);

            return View("AddMovie", movie);
        }
        [HttpPost]
        public IActionResult Edit (ApplicationResponse movie)
        {
            _MovieContext.Update(movie);
            _MovieContext.SaveChanges();
            return RedirectToAction("ViewCollection");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _MovieContext.Responses.Single(x => x.MovieId == id);
            return View(movie);

        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            _MovieContext.Responses.Remove(ar);
            _MovieContext.SaveChanges();
            return RedirectToAction("ViewCollection");

        }


    }
}
