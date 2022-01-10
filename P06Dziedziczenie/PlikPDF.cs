using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Dziedziczenie
{
    class PlikPDF : Plik
    {
        public override void Zapisz()
        {
            Console.WriteLine("Zapisuje plik PDF");
        }

    }
}
