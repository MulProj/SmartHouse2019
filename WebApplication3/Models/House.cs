﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class House
    {
        public int HouseId { get; set; }
        public string Description { get; set; }
        public ICollection<Sensor> Sensors { get; set; }
    }
}
