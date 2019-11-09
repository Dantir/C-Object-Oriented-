using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void CallComputerInfo(Computer comp)
        {
            comp.PrintInfo();
        }
        static void Main(string[] args)
        {
            //Computer computer1 = new Computer(1920,1080);
            //Computer computer2 = new Computer(Color.White, "Asus", 800, 400);
            Computer computer1 = new Computer();
            computer1.Colorname = Color.Black;
            computer1.Brand = "Dell";
            computer1.MonitorWidth = 1920;
            computer1.MonitorHeight = 1080;
            Computer Clone = computer1.Clone();
            CallComputerInfo(computer1);
            Console.WriteLine(computer1.GetArea());
            CallComputerInfo(Clone);
            //CallComputerInfo(computer2);

            Console.ReadKey();
        }
    }
}
