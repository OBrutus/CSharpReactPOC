using EkamArtMBProj.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Order order)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Checkout");
            }
            return View();
        }

        public ActionResult Checkout()
        {
            ViewBag.CheckoutMsg = "Thanks for you order. You'll soon receive the art & enjoy the painting adorning your space! ";
            return View();

        }
    }
}
