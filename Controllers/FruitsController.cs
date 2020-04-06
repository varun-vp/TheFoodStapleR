using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TheFoodStapleEx.Controllers
{
    
    public class FruitsController : Controller
    {
        [Authorize]
        public IActionResult Fruit()
        {
            return View();
        }
    }
}