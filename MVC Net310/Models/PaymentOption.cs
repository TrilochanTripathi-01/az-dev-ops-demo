using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Net310.Models
{
    public class PaymentOption
    {
        public int Id { get; set; }
        public List<Payment> Payments { get; set; }
    }
    public class Payment
    {
        public int Id { get; set; }
        public string PayType { get; set; }
        public string CardNumber { get; set; }

        public string ValidTill { get; set; }
        public string Cvv { get; set; }

    }
}
