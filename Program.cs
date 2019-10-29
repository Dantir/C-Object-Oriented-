using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LightBulb first = new LightBulb();
            first.Color = "White";
            first.Shape = "Candle";
            first.SetState("Off");
            Console.Write(first.info());
            first.SetState("On");
            Console.Write(first.info());
            Console.ReadLine();
        }
    }
}
