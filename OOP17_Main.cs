using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            UnsignedInt int1 = new UnsignedInt(3) + new UnsignedInt(4);
            Console.WriteLine(int1);
            UnsignedInt int2 = new UnsignedInt(3) + new UnsignedInt(-2); //-2 can't be inside uint
            Console.WriteLine(int2);
            UnsignedInt int3 = new UnsignedInt(3) + 4;
            Console.WriteLine(int3);
            UnsignedInt int4 = 4 + new UnsignedInt(3);
            Console.WriteLine(int4);
            UnsignedInt int5 = new UnsignedInt(3) - new UnsignedInt(2);
            Console.WriteLine(int5);
            UnsignedInt int6 = new UnsignedInt(3) - new UnsignedInt(4);
            Console.WriteLine(int6);
            UnsignedInt int7 = new UnsignedInt(3) - 1;
            Console.WriteLine(int7);
            UnsignedInt int8 = 4 - new UnsignedInt(3);
            Console.WriteLine(int8);
            UnsignedInt int9 = new UnsignedInt(3) * 3;
            Console.WriteLine(int9);
            UnsignedInt int10 = -3 * new UnsignedInt(3);
            Console.WriteLine(int10);
            UnsignedInt int11 = new UnsignedInt(3) * new UnsignedInt(3);
            Console.WriteLine(int11);
            UnsignedInt int12 = new UnsignedInt(3) * new UnsignedInt(3);
            Console.WriteLine(int12);
            UnsignedInt int13 = new UnsignedInt(3) * new UnsignedInt(-3);
            Console.WriteLine(int13);
            UnsignedInt int14 = new UnsignedInt(3) / new UnsignedInt(-3);
            Console.WriteLine(int14);
            UnsignedInt int15 = new UnsignedInt(3) / 3;
            Console.WriteLine(int15);
            UnsignedInt int16 = 6 / new UnsignedInt(3);
            Console.WriteLine(int16);
            Console.ReadKey();
        }
    }
}
