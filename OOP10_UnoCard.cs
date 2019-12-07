using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP10
{
    enum UnoCardType { Zero = 0, Two = 1, Three = 2, Four = 3, Five = 4, Six = 5, Seven = 6, Eight = 7,
                       Nine = 8, Draw_Two = 9, Skip = 10, Reverse = 11, Wild = 12, Wild_Draw_Four = 13 };
    enum UnoCardColor { Red = 1, Green = 2, Yellow = 3, Blue = 4 };

    class UnoCard: ICardInfo
    {
        private int Type;
        private int Color;
        public UnoCard(int Type, int Color)
        {
            this.Type = Type;
            this.Color = Color;
        }
        public void ShowCard()
        {
            Console.WriteLine("You're looking at " + (Enum.GetName(typeof(UnoCardType), Type) + " of " + (Enum.GetName(typeof(UnoCardColor), Color))));
        }
    }
}
