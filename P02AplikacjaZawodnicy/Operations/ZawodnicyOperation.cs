﻿using P02AplikacjaZawodnicy.Domain;
using P02AplikacjaZawodnicy.Repositories;

using P02AplikacjaZawodnicy.ViewModels;
using P05Biblioteka;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02AplikacjaZawodnicy.Operations
{
    class ZawodnicyOperation
    {
        ZawodnicyRepository zawodnicyRepository = new ZawodnicyRepository();
        public ZawodnikVM[] PodajZawodnikow()
        {
            var zawodnicy = zawodnicyRepository.PodajZawodnikow();

            return zawodnicy.Select(x => new ZawodnikVM()
            {

                Id = x.id_zawodnika,
                Imie = x.imie,
                Nazwisko = x.nazwisko,
                Kraj = x.kraj,
                DataUrodzenia = x.data_ur,
                Waga = x.waga,
                Wzrost = x.wzrost
            }).ToArray();
        }

        public void DodajZawodnika(ZawodnikVM zv)
        {
            var z = KonwertujZawodnikVMnaZawodnik(zv);
            zawodnicyRepository.DodajZawodnika(z);
        }

        public void EdytujZawodnika(ZawodnikVM zv)
        {
            var z = KonwertujZawodnikVMnaZawodnik(zv);
            zawodnicyRepository.EdytujZawodnika(z);
        }

        public ZawodnikVM[] WygenerujRaportPDF()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            var zaw =  zr.PodajZawodnikow();
            string[] linie = zaw.Select(x => x.imie + " " + x.nazwisko + " " + x.kraj).ToArray();
            PDFManager pm = new PDFManager();
            string sciezka= "HelloWorld.pdf";
            pm.WygenerujPDF(sciezka, linie);
            Process.Start(sciezka);

            return zaw.Select(x => new ZawodnikVM()
            {
                Id = x.id_zawodnika,
                Imie = x.imie,
                Nazwisko = x.nazwisko,
                Kraj = x.kraj
            }).ToArray();
        }

        public DaneWykresu WygenerujDaneDoWykresu()
        {
            var zawodnicy = zawodnicyRepository.PodajZawodnikow();
            var grupy =  zawodnicy
                .Where(x=>x.wzrost != null)
                .GroupBy(x => x.kraj)
                .Select(x => new { Kraj = x.Key, Wzrost = x.Average(y => y.wzrost) }).ToArray();

            DaneWykresu daneWykresu = new DaneWykresu();
            daneWykresu.X = grupy.Select(x => x.Kraj).ToArray();
            daneWykresu.Y = grupy.Select(x => (double)x.Wzrost).ToArray();
            return daneWykresu;
        }

        private Zawodnik KonwertujZawodnikVMnaZawodnik(ZawodnikVM zv)
        {
            Zawodnik z = new Zawodnik()
            {
                imie = zv.Imie,
                nazwisko = zv.Nazwisko,
                kraj = zv.Kraj,
                data_ur = zv.DataUrodzenia,
                waga = zv.Waga,
                wzrost = zv.Wzrost
            };

            if (zv.Id != null)
                z.id_zawodnika = (int)zv.Id;

            return z;
        }
    }
}
