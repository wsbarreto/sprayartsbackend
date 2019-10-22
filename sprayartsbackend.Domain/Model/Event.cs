﻿using System;
using System.Collections.Generic;
using System.Text;

namespace sprayartsbackend.Domain.Model
{
    public class Event : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime DateEvent { get; set; }
        public decimal Value { get; set; }
    }
}
