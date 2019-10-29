using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs first = new Dogs();
            first.Name = "Lucy";
            first.Race = "Bulldog";
            first.Color = "Brown";
            first.setWeight(9.2);
            first.setAge(5);
            Console.Write("Dog 1" + first.info());
            Dogs second = new Dogs();
            second.Name = "Molly";
            second.Race = "Labrador";
            second.Color = "Light Brown";
            second.setWeight(12.4);
            second.setAge(3);
            Console.Write("Dog 2" + second.info());
            Console.ReadKey();
        }
    }
}
