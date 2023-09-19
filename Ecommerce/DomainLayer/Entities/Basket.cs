﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Basket : BaseEntity
    {
        public string? ProductName { get; set; }
        public string? Image { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int AppUserId { get; set; }

        public AppUser? AppUser { get; set; }
    }
}
