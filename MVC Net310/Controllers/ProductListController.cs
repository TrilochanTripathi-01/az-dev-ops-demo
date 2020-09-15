using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Net310.Models;

namespace MVC_Net310.Controllers
{
    public class ProductListController : Controller
    {
        public IActionResult Index()
        {
            
            var pvm = new ProductsViewModel();
            pvm.Products=new List<ProductsViewModel>();

            pvm.Products = new List<ProductsViewModel>
            {
                new ProductsViewModel {Id = 1, Description = "No Desc A", Name = "Apple", SellPrice = 1},
                new ProductsViewModel {Id = 2, Description = "No Desc B", Name = "Orange", SellPrice = 10},
                new ProductsViewModel {Id = 3, Description = "No Desc A", Name = "Banana", SellPrice = 1},
                new ProductsViewModel {Id = 4, Description = "No Desc B", Name = "Guava", SellPrice = 10},
                new ProductsViewModel {Id = 5, Description = "No Desc A", Name = "Ram", SellPrice = 1},
                new ProductsViewModel {Id = 6, Description = "No Desc B", Name = "Computer", SellPrice = 10},
                new ProductsViewModel {Id = 7, Description = "No Desc A", Name = "Hard Disk", SellPrice = 1},
                new ProductsViewModel {Id = 8, Description = "No Desc B", Name = "IPod", SellPrice = 10},
                new ProductsViewModel {Id = 9, Description = "No Desc A", Name = "Laptop", SellPrice = 1},
                new ProductsViewModel {Id = 10, Description = "No Desc B", Name = "Charger", SellPrice = 10},
                new ProductsViewModel {Id = 11, Description = "No Desc A", Name = "Product A", SellPrice = 1},
                new ProductsViewModel {Id = 12, Description = "No Desc B", Name = "Product B", SellPrice = 10}
            };
            return View(pvm.Products);
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            return View();
        }
    }
}