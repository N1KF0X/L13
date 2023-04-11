using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_13
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

        }
    }
}
