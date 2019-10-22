using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Domain.Model
{
    public class Payment : Entity
    {
        public decimal Value { get; set; }
        public DateTime DatePay { get; set; }
        public string PaymentStatus { get; set; }

        public virtual Event Event { get; set; }
    }
}
