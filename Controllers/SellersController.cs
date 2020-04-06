using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TheFoodStapleEx.Controllers
{
    public class SellersController : Controller
    {
        [Authorize(Roles = "Admin,Seller")]
        public IActionResult Seller()
        {
            return View();
        }
        [Authorize(Roles="Admin,Seller")]
        public IActionResult GetOrder()
        {
            return View();
        }
        [Authorize(Roles = "Admin,Seller")]
        public IActionResult AddFood()
        {
            return View();
        }
    }
}