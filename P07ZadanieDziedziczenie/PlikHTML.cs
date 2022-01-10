using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadanieDziedziczenie
{
    class PlikHTML : Plik
    {
        private string szablonHTML = @"<HTML>
                    <body>
                    <p>{0}</p>
                    </body>
                    </html>";

        public override void Zapisz()
        {
            Zawartosc = string.Format(szablonHTML, Zawartosc);
            //File.WriteAllText(Sciezka + ".html", Zawartosc);
            Sciezka += ".html";
            base.Zapisz();
        }
    }
}
