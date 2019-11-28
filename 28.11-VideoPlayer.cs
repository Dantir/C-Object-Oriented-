using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VideoPlayer:IPlayer
    {
        private string fileName;
        public VideoPlayer(string fileName)
        {
            this.fileName = fileName;
        }
        public void Play()
        {
            Console.WriteLine( "Playing film: " + fileName);
        }
        public void Stop()
        {
            Console.WriteLine( "Stopping film: " + fileName);
        }
        public void Next()
        {
            Console.WriteLine("Playing Next Film: " + fileName);
        }
    }
}
