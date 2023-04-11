using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_13
{
    internal interface IBook <T>: IRelezer
    {
        void Date(string bookName, T date, int pagesAmount);
    }
}
