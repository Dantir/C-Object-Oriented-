using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP10
{
    enum CardType { Two = 1, Three = 2, Four = 3, Five = 4, Six = 5, Seven = 6, Eight = 7,
                    Nine = 8, Ten = 9, Jack = 10, Dame = 11, King = 12, Ace = 13 };
    enum CardSuit { Hearts = 1, Diamonds = 2, Clubs = 3, Spades = 4 };

    class Card : ICardInfo
    {
        private int Type;
        private int Suit;
        public Card(int Type, int Suit)
        {
            this.Type = Type;
            this.Suit = Suit;
        }
        public void ShowCard()
        {
            Console.WriteLine("You're looking at " + (Enum.GetName(typeof(CardType),Type) + " of " + (Enum.GetName(typeof(CardSuit),Suit)))) ;
        }
    }
}
