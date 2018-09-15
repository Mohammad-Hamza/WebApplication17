using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class AddDetailController : Controller
    {
        Movie_1Context _ORM = null;
        public AddDetailController(Movie_1Context ORM)
        {
            _ORM = ORM;
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovie(Movie1 M)
        {
            _ORM.Movie1.Add(M);
            _ORM.SaveChanges();
            ViewBag.Message = "Movie details has been added:";
            return View();
        }
        [HttpGet]
        public IActionResult AddCinema()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCinema(Cinema C)
        {
            _ORM.Cinema.Add(C);
            _ORM.SaveChanges();
            ViewBag.Message = "Cinema details has been added:";
            return View();
        }

    }
}