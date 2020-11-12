using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRegistrationValidation.Models;

namespace MovieRegistrationValidation.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieRegistrationForm()
        {
            return View(new Movie());
        }

        public IActionResult DisplayMovie(Movie M)
        {
            if (ModelState.IsValid)
            {
                return View("DisplayMovie", M);
            }
            else
            {
                return View("MovieRegistrationForm", M);
            }
        }

        //public IActionResult AddActorsForm(Movie M)
        //{
        //    return View("AddActorsForm",M);
        //}

        //public IActionResult AddActorsFormStep(Movie M, string FirstName, string LastName, string command)
        //{
        //    if (command.Equals("Add"))
        //    {
        //        // TODO Add Actor to Actors list
        //    }
        //    else if (command.Equals("Proceed"))
        //    {
        //        // TODO Proceed to DirectorsForm 
        //    }
        //}
    }
}
