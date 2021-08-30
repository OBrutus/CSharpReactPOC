using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebCoreMvcTemplate.Models;

namespace WebCoreMvcTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Title  = 7699;
            ViewData["Movie Name"] = "Hollywood Movies";
            return View();
        }

        public int add()
        {
            return 2 + 2;
        }
        public string Hello(string custname, int custid = 101)
        {
            return HttpUtility.HtmlEncode("Hello! " + custname + ":" + custid);

        }


        public JsonResult jsondata()
        {
            string result = "welcome to json action";
            return Json(result);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
