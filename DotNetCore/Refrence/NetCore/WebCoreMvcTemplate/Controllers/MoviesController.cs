using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreMvcTemplate.Models;

namespace WebCoreMvcTemplate.Controllers
{
    public class MoviesController : Controller
    {
        // GET: MoviesController
        public ActionResult Index()

        {
            var model = from m in _movieInfo
                        orderby m.MName
                        select m;

            return View(model);
        }

        // GET: MoviesController/Details/5
        public ActionResult Details(int id)
        {
            var movrec = _movieInfo.Single(m => m.id == id);
            return View(movrec);
        }

        // GET: MoviesController/Create
        [HttpGet]
        public ActionResult Create()
        {
            var movitem = new Movie();
            return View(movitem);
        }

        // POST: MoviesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movnewitem)
        {
            try
            {
                _movieInfo.Add(movnewitem);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MoviesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MoviesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MoviesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MoviesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        static List<Movie> _movieInfo = new List<Movie>()
        {
            new Movie
            {
                id = 1,
                MName = "Avatar",
                MStar = "Tim",
                MRating = 5
            },

            new Movie
            {
                id = 2,
                MName = "Moana",
                MStar = "Dayne",
                MRating = 5
            },
            new Movie
            {
                id = 3,
                MName = "Wanted",
                MStar = "Angie",
                MRating = 5
            },
            new Movie
            {
                id = 4,
                MName = "Avenger",
                MStar = "Scar Jo",
                MRating = 5
            }

        };


    }



}
