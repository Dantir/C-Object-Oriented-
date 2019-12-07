using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP10
{
    class Deck : IDeckOperations
    {
        private ICardInfo[] Cards;
        public int CardIndex;
        public void CreateDeck(int Type)
        {
            if (Type == 1)
            {
                Cards = new ICardInfo[52];
                for (int SuitCount = 1; SuitCount <= Enum.GetNames(typeof(CardSuit)).Length; SuitCount++)
                {
                    for (int TypeCount = 1; TypeCount <= Enum.GetNames(typeof(CardType)).Length; TypeCount++, CardIndex++)
                    {
                        Cards[CardIndex] = new Card(TypeCount, SuitCount);
                    }
                }
            }
            else if (Type == 2)
            {
                Cards = new ICardInfo[108];
                for (int ColorCount = 1; ColorCount <= Enum.GetNames(typeof(UnoCardColor)).Length; ColorCount++)
                {
                    for (int TypeCount = 0; TypeCount < Enum.GetNames(typeof(UnoCardType)).Length; TypeCount++, CardIndex++)
                    {
                        if (TypeCount != 0)
                        {
                            Cards[CardIndex] = new UnoCard(TypeCount, ColorCount);
                            CardIndex++;
                        }
                        Cards[CardIndex] = new UnoCard(TypeCount, ColorCount);
                    }
                }
            }
            Console.WriteLine("You created a deck with " + CardIndex + " cards");
        }
        public void RemoveCards()
        {
            Console.WriteLine("How many cards from your deck do you want to remove?\n*Please write number between 1 and " + CardIndex);
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                try
                {
                    if (CardIndex >= 0)
                    {
                        Cards[CardIndex - 1].ShowCard();
                        Cards = Cards.Take(Cards.Count() - 1).ToArray();
                        CardIndex--;
                        Console.WriteLine("You removed it from your deck\n");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, no more cards :(");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, wrong index :(");
                    break;
                }
            }
            Console.WriteLine("You deck now has " + CardIndex + " cards");
        }
        public void Shuffle()
        {
            Random rnd = new Random();
            ICardInfo[] MyRandomArray = Cards.OrderBy(x => rnd.Next()).ToArray();
            Cards = MyRandomArray;
            Console.WriteLine("You shuffled your deck");
        }
    }
}
