﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieListWehde.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace MovieListWehde.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}