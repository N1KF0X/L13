using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13
{
    internal class Bibioteka<T>: IBook<T>
    {

        public void Date(string bookName, T date, int pagesAmount)
        {
            Console.WriteLine("Книга " + bookName + ":\n" +
                "Вышла - " + date + "\n" +
                "Страниц - " + pagesAmount +
                "\n");
        }

        public void NewBook(string autor, string bookName)
        {
            Console.WriteLine(autor + " выпустил книгу - " + bookName + "\n");  
        }
    }
}
