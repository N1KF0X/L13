using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13
{
    internal interface IUser <T>
    {
        void Autariretion(T login, string password);
    }
}
