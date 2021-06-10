using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Patterns.Behavioral.Visitor
{
    public abstract class Product
    {
        public double Price { get; set; }

        public int Amount { get; set; }

        public Product(double price, int amount)
        {
            Price = price;
            Amount = amount;
        }

        public abstract double Accept(Visitor visitor);
    }
}
