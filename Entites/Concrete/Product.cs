﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entites.Concrete
{
   public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitePrice { get; set; }
    }
}
