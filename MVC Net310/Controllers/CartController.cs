using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Net310.Models;

namespace MVC_Net310.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name,decimal sellPrice,string description,int id)
        {
            var pvm = new ProductsViewModel();
            pvm.Products = new List<ProductsViewModel>();

            pvm =
                new ProductsViewModel {Id = id, Description = description, Name = name, SellPrice = sellPrice};
                
            return View(pvm);
        }
        [HttpGet]
        public IActionResult Payment()
        {
            var pvm = new ProductsViewModel();
            pvm.Products = new List<ProductsViewModel>();

            

            return View("Payment", new Payment{CardNumber = "5210-0000-0111-0000",PayType = "Credit Card",ValidTill = "12/2025",Cvv = "000"});
        }
        [HttpPost]
        public IActionResult Payment(string name,decimal sellPrice,string description,int id)
        {
            return View("ThankYou");
        }
        [HttpGet]
        public IActionResult ThankYou()
        {
            return View("ThankYou");
        }
    }
}