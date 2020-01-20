using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP19
{
    class Product
    {
        public int id;
        public string Name;
        public Colors Color;
        public double Price;
        public Product(int id, string Name, Colors Color, double Price)
        {
            this.id = id;
            this.Name = Name;
            this.Color = Color;
            this.Price = Price;
        }
        public override string ToString()
        {
            return "ID: "+ id + ", Name: " + Name + ", Color: " + Color + ", Price: " + Price;
        }
    }
}
