﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
        public int UnitsInStock { get; set; }

        public string? ImagePath { get; set; }
    }
}
