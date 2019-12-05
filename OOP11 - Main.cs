using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinates value = new Coordinates(2,4,6);
            Door valuedoor = new Door("Onion", 12, 3);
            Console.WriteLine(value);
            Console.WriteLine(valuedoor);
            ChangeX(value, 5);
            ChangeHeight(valuedoor, 5);
            Console.WriteLine(value);
            Console.WriteLine(valuedoor);
            Coordinates coordinateCopied = CopyCoordinate(value);
            Door doorCopied = CopyDoor(valuedoor);
            Console.WriteLine(coordinateCopied);
            Console.WriteLine(doorCopied);
            Console.ReadKey();
        }
        public static void ChangeX(Coordinates value, int newx)
        {
            value.X = newx;
        }
        public static void ChangeHeight(Door value, int newheight)
        {
            value.Height = newheight;
        }
        static Coordinates CopyCoordinate(Coordinates coordinateToCopy)
        {
            Coordinates coordinateCopied = coordinateToCopy;
            return coordinateCopied;
        }
        static Door CopyDoor(Door doorToCopy)
        {
            Door doorCopied = new Door();
            doorCopied.Color = doorToCopy.Color;
            doorCopied.Height = doorToCopy.Height;
            doorCopied.Width = doorToCopy.Width;
            return doorCopied;
        }
    }
}
