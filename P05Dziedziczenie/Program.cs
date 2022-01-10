using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plik> pliki = new List<Plik>();
            pliki.Add(new PlikCSV());
            pliki.Add(new PlikHTML());
            pliki.Add(new PlikPDF());

            foreach (var plik in pliki)
            {
                if (plik is PlikCSV)
                {
                    var p = (PlikCSV)plik;
                    p.Zapisz();
                }
                if (plik is PlikHTML)
                {
                    var p = (PlikHTML)plik;
                    p.Zapisz();
                }
                if (plik is PlikPDF)
                {
                    var p = (PlikPDF)plik;
                    p.Zapisz();
                }
            }

            Console.ReadKey();
        }
    }
}
