using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Net310.Models
{
    public class ProductsViewModel
    {
       public IList<ProductsViewModel> Products { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal SellPrice { get; set; }
    }
}
