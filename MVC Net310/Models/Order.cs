using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Net310.Models
{
    public class Order
    {
        [Key]
        public string OrderNumber { get; set; }
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [DisplayName("Shipping Address")]
        public string ShippingAddress { get; set; }
        [DisplayName("Billing Address")]
        public string BillingAddress { get; set; }
        [DisplayName("Item")]
        public string ItemName { get; set; }
        [DisplayName("Qty")]
        public int PurchasedQty { get; set; }
        [DisplayName("Price")]
        public decimal ItemPrice { get; set; }

    }
}
