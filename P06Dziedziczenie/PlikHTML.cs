using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Dziedziczenie
{
    class PlikHTML : Plik
    {
        public new void Zapisz()
        {
            Console.WriteLine("Zapisz plik HTML");
        }

    }
}
