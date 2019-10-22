using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Domain.Model
{
    public class Card : Payment
    {
        public string Number { get; set; }
        public DateTime ValidDate { get; set; }
        public string NameOfCard { get; set; }
        public int CodeSecurity { get; set; }
    }
}
