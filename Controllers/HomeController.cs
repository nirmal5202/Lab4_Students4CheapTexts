using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab4_Students4CheapTexts.Models;

namespace Lab4_Students4CheapTexts.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // [HttpGet]
        public IActionResult Appraise()
        {
            return View();
        }

        /*
        [HttpPost]
        public IActionResult Appraise(Textbooks textbooks)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    ViewData["Message"] = "Title: " + textbooks.title + 
                                            "\n Version: " + textbooks.version + 
                                            "\n Price: " + textbooks.price;

                    ViewData["Message"] = "Your book: " + calcValue(textbooks.price);

                    return View("Appraised", textbooks);
                }
                else
                {
                    message = "Failed to create textbook. Please try again";
                }
                return Content(message);
            }
        }

        */

    }
}
