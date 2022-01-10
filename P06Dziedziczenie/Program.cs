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
            pliki.Add(new Plik());
            pliki.Add(new PlikCSV());
            pliki.Add(new PlikHTML());
            pliki.Add(new PlikPDF());

            foreach (var p in pliki)
            {
                p.Zapisz();
            }

            Console.ReadKey();
        }
    }
}
