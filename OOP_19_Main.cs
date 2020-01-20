using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP19
{
    public enum Colors : int
    {
        White = 1, Black = 2, Gray = 3, Blue = 4, Green = 5
    }
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
            new Product(1, "Mouse",Colors.Black, 39),
            new Product(2, "Keyboard", Colors.Black, 49),
            new Product(3, "Monitor", Colors.Gray, 460),
            new Product(4, "Speakers 2.1", Colors.Blue, 70),
            new Product(5, "Speakers 5.1", Colors.Black, 250)
            };

            Console.WriteLine("Names:");
            var names = products.Select(Product => Product.Name);
            foreach (var name in names)
                Console.WriteLine(name);

            Console.WriteLine("\nNames and Prices:");
            var names_prices = products.Select(Product => Product.Name + " " + Product.Price);
            foreach (var name_price in names_prices)
                Console.WriteLine(name_price);

            Console.WriteLine("\nSpeakers:");
            var speakers = products
                    .Where (speaker => speaker.Name.Contains("Speakers"));
            foreach (var speaker in speakers)
                Console.WriteLine(speaker.ToString());

            Console.WriteLine("\nBlack products:");
            var blackcolors = products
                    .Where(black => black.Color == Colors.Black);
            foreach (var black in blackcolors)
                Console.WriteLine(black.ToString());

            Console.WriteLine("\nCheap products:");
            var cheaps = products
                    .Where(cheap => cheap.Price < 100);
            foreach (var cheap in cheaps)
                Console.WriteLine(cheap.ToString());

            Console.WriteLine("\nNot black names:");
            var nbnames = products
               .Where (nbname => nbname.Color != Colors.Black)
               .Select(nbname => nbname.Name);
            foreach (var nbname in nbnames)
                Console.WriteLine(nbname);

            Console.WriteLine("\nBlack and expensive IDs:");
            var blackandexpensives = products
                .Where(blackandexpensive => blackandexpensive.Color == Colors.Black && blackandexpensive.Price > 200)
                .Select(blackandexpensive => blackandexpensive.id);
            foreach (var blackandexpensive in blackandexpensives)
                Console.WriteLine(blackandexpensive);

            Console.WriteLine("\nProduct with ID 4:");
            var id4s = products
                .Where(id4 => id4.id == 4);
            foreach (var id4 in id4s)
                Console.WriteLine(id4.ToString());

            Console.WriteLine("\nAverage Price:");
            var avgprices = products
                .Select(avgprice => avgprice.Price);
            Console.WriteLine(avgprices.Average());

            Console.WriteLine("\nBiggest ID:");
            var biggestIDs = products
                .Select(biggestID => biggestID.id);
            Console.WriteLine(biggestIDs.Max());

            Console.WriteLine("\nDescending Prices:");
            var DescPrices = products
                .OrderByDescending(DescPrice => DescPrice.Price);
            foreach (var DescPrice in DescPrices)
                Console.WriteLine(DescPrice.ToString());
            Console.ReadKey();
        }
    }
}
