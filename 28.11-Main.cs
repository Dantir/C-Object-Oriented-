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
            IPlayer[] Array = new IPlayer[2];
            Array[0] = new MusicPlayer(new string[] { "Yellow Box", "Poznan", "Selah", "White Room", "19-2000" });
            Array[1] = new VideoPlayer("Irlandczyk");
            foreach (var element in Array)
            {
               element.Play();
            }
            for (int i = 0; i<6;i++)
            {
                Array[0].Next();
                Array[1].Next();
            }
            Console.ReadKey();
        }
    }
}
