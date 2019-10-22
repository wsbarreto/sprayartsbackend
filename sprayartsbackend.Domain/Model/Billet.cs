using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Domain.Model
{
    public class Billet : Payment
    {
        public DateTime DateExpiry { get; set; }
        public string Number { get; set; }
    }
}
