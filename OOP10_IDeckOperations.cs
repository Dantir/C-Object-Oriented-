using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP10
{
    interface IDeckOperations
    {
        void CreateDeck(int Type);
        void RemoveCards();
        void Shuffle();
    }
}
