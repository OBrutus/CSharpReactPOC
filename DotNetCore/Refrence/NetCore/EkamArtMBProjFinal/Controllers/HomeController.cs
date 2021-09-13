using EkamArtMBProj.Models;
using EkamArtMBProj.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPaintingRepo _paintingRepo;

        //DI
        public HomeController(IPaintingRepo paintingRepo)
        {
            _paintingRepo = paintingRepo;

        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PaintingsOfTheWeek = _paintingRepo.PaintingsOfTheWeek
            };
             return View(homeViewModel);
        }
    }
}
