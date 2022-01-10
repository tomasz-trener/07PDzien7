using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Plik[] pliki = new Plik[]
            {
                new PlikCSV { Sciezka=@"C:\dane\pliki\p1", Zawartosc = "ala ma kota"},
                new PlikHTML { Sciezka=@"C:\dane\pliki\p2", Zawartosc = "ala ma kota"},
                new PlikSQL { Sciezka=@"C:\dane\pliki\p3", Zawartosc = "ala ma kota"},
            };

            foreach (var p in pliki)
                p.Zapisz();

            //Plik plik = new Plik();
            

        }
    }
}
