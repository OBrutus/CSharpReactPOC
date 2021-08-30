using EkamArtMBProj.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Controllers
{
    public class PaintingController : Controller
    {
        private IPaintingRepo _paintingdata;
        //Dependency Injection
        public PaintingController(IPaintingRepo paintingrepo)
        {
            _paintingdata = paintingrepo;

        }
        public IActionResult Index()
        {
            var model = _paintingdata.GetAllPaintings();
            return View(model);
        }
    }
}
