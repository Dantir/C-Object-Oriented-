using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP10
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck NewDeck = new Deck();

            Console.WriteLine("What type of deck you want to create?(Please don't write other numbers and especially letters) \n1 - Poker Cards \n2 - Uno Cards");
            int Type = int.Parse(Console.ReadLine());

            NewDeck.CreateDeck(Type);
            NewDeck.Shuffle();
            NewDeck.RemoveCards();

            Console.ReadKey();
        }
    }
}
