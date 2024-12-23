﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banhang
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Image Image { get; set; }

        public Product(string name, decimal price, int quantity, Image image)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Image = image;
        }
    }
}
