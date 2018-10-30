﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Leon the professional!"};
//            return View(movie);
//            return Content("Hello World");
//            return HttpNotFound();
//            return new EmptyResult();  // returns empty result 
            return RedirectToAction("Index", "Home", new{page =1, sortBy = "name"});

        }
    }
}