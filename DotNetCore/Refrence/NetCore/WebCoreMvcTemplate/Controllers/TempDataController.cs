using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreMvcTemplate.Models;

namespace WebCoreMvcTemplate.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult Index()
        {
            Customer cust = new Customer()
            {
                CustName = "Krish",
                City = "Chennai"
            };

            String strcust = JsonConvert.SerializeObject(cust);
            TempData["CustInfo"] = strcust;

           return new RedirectResult(@"Home\");
        }
    }
}
