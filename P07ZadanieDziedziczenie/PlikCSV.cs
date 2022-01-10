using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieDziedziczenie
{
    class PlikCSV : Plik
    {
        public override void Zapisz()
        {
            Zawartosc = Zawartosc.Replace(" ", ";");
            //File.WriteAllText(Sciezka + ".csv", Zawartosc);
            Sciezka += ".csv";
            base.Zapisz();


        }
    }
}
