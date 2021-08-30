using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webcoreemptytemp.Pages
{
    public class MyRazorModel : PageModel
    {
        public string Message;
        public void OnGet()
        {
            Message = "From Razor!";
        }
    }
}
