using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieDziedziczenie
{
    class PlikSQL : Plik
    {
        public override void Zapisz()
        {
            Zawartosc = $"SELECT {Zawartosc} FROM dane";
            //File.WriteAllText(Sciezka + ".sql", Zawartosc);
            Sciezka += ".sql";
            base.Zapisz();
        }
    }
}
