using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstTest.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace firstTest.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /Movies/
        // GET: /Movies/Index
        public IActionResult Index() 
        {
            ViewData["Name"] = "Ghada";
            //ViewBag["Grade"] = 99;

            return View();
            //return View();, which specified that the method should use a view template file to render a response to the browser.
        }




        public IActionResult Welcome(string name , string city = "Riyadh")
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["City"] = city;

            return View();
        }

        public IActionResult Edit(int name)
        {

            return Content("id= " + name);
        }

        public IActionResult Random()
        {
            var movie = new Movie() {
                Id = 1,
                Title = "catch me if you can",
                Type = "Action"
            };

            ViewData["movie"] = movie;
            return View();
        }


        //// GET: /Movies/details
        //public string Details(int id)
        //{
        //    return ("Hi, I'm MoviesController inside Action 'Details' {0}" + id);
        //}
    }
}
