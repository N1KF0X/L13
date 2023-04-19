using L13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13
{
    internal class Buy<T> : IBook<T>, IUser<T>
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

        public void Buing(T login, string boolName)
        {
            Console.WriteLine("пользователь " + login +" купил книгу " + boolName +"\n");
        }

        public void Autariretion(T login, string password)
        {
            Console.WriteLine("Был совершён вход:\n" +
                "Логин - " + login +
                "Пароль - " + password + "\n");
        }
    }
}
