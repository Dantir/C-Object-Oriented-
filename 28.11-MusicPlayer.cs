using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MusicPlayer:IPlayer
    {
        private int CurrentlyPlayingIndex = 0;
        private string[] songList;
        public MusicPlayer(string[] songNames)
        {
            songList = songNames;
        }
        public void Play()
        {
            Console.WriteLine("Playing song: " + songList[CurrentlyPlayingIndex]);
        }
        public void Stop()
        {
            Console.WriteLine("Stopping song: " + songList[CurrentlyPlayingIndex]);
        }
        public void Next()
        {
            CurrentlyPlayingIndex++;

            if (CurrentlyPlayingIndex == songList.Length)
                CurrentlyPlayingIndex = 0;

            Console.WriteLine("Playing Next Song: " + songList[CurrentlyPlayingIndex]);
        }
    }
}
