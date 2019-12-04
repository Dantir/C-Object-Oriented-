using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP9_2_
{
    public interface IBook
    {
        /*string name();
        string author();
        string[] pages();*/
        void PrintInfoBook();
        void PrintInfoPage( int pageNumber);
    }
}
