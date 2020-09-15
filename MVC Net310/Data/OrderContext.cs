using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Net310.Models;

namespace MVC_Net310.Data
{
    public class OrderContext:DbContext
    {
        public OrderContext()
        {
                
        }
        public OrderContext(DbContextOptions<OrderContext> options):base(options)
        {
        }
        public DbSet<Order> Order { get; set; }
        public DbSet<MVC_Net310.Models.ProductsViewModel> ProductsViewModel { get; set; }
        public DbSet<MVC_Net310.Models.PaymentOption> PaymentOption { get; set; }
        public DbSet<MVC_Net310.Models.Payment> Payment { get; set; }
    }
}
