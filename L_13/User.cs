using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13
{
    internal class User<T> : IUser<T>
    {
        public void Autariretion(T login, string password)
        {
            Console.WriteLine("Был совершён вход:\n" +
                "Логин - " + login +
                "Пароль - " + password + "\n");
        }
    }
}
