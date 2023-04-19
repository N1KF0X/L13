using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string autor = "Пушкин";
            string book = "Сказки";

            Bibioteka<float> bibioteka = new Bibioteka<float>();
            Bibioteka<string> bibioteka1 = new Bibioteka<string>();
            bibioteka.NewBook(autor, book);

            bibioteka.Date(book, 02.03f, 200);
            bibioteka1.Date(book, "02.03", 200);

            User<int> user = new User<int>();
            User<string> user1 = new User<string>();

            user.Autariretion(33242424, "232321323");
            user1.Autariretion("wwewqeqe", "321331313");

            Buy<int> buy = new Buy<int>();

            buy.Buing(343242442, book);

        }
    }
}
