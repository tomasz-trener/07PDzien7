using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieDziedziczenie
{
    abstract class Plik
    {
        public string Zawartosc;
        public int Rozmiar;
        public string Autor;
        public string Sciezka;

        public virtual void Zapisz()
        {
            File.WriteAllText(Sciezka, Zawartosc);
        }
    }
}
