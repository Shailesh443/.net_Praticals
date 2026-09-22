using Practical_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Web.Mvc;
using Practical_6.Models;

namespace Practical_6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Category = "Electronics",
                    Price = 55000
                },

                new Product
                {
                    Id = 2,
                    Name = "Mobile",
                    Category = "Electronics",
                    Price = 25000
                },

                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Category = "Accessories",
                    Price = 2000
                },

                new Product{
                    Id = 4,
                    Name = "Shoes",
                    Category = "Footwear",
                    Price = 3000    
            },
                new Product{
                    Id = 5,
                    Name = "Watch",
                    Category = "Accessories",
                    Price = 5000
                }
            };  

            return View(products);
 
        }
    }
}