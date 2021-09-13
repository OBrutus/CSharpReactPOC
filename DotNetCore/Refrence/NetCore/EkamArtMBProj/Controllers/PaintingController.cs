using EkamArtMBProj.Models;
using EkamArtMBProj.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Controllers
{
    public class PaintingController : Controller
    {
        private readonly IPaintingRepo _paintingRepo;
        private readonly ICategoryRepo _categoryRepo;
        //Dependency Injection
        public PaintingController(IPaintingRepo paintingRepo,ICategoryRepo categoryRepo)
        {
            _paintingRepo = paintingRepo;
            _categoryRepo = categoryRepo;

        }
        public IActionResult Index(string category)
        {
            IEnumerable<Painting> paintings;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                paintings = _paintingRepo.Allpaintings.OrderBy(p => p.PaintingId);
                currentCategory = "All Paintings";
            }
            else
            {
                paintings = _paintingRepo.Allpaintings.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PaintingId);
                currentCategory = _categoryRepo.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new PaintingsListViewModel
            { 
                Paintings = paintings,
                CurrentCategory = currentCategory
            });
        }
    }
}
