using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TheFoodStapleEx.Controllers
{
    public class VegetablesController : Controller
    {
        [Authorize(Policy = "readonlypolicy")]
        
        public IActionResult Vegetable()
        {
            return View();
        }
    }
}