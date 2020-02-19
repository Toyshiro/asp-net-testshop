using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestShop.Models;

namespace TestShop.Controllers
{
    public class HomeController : Controller
    {
        ShopContext db;

        public HomeController(ShopContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }


    }
}
