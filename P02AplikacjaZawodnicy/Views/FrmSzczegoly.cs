using P02AplikacjaZawodnicy.Operations;
using P02AplikacjaZawodnicy.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaZawodnicy.Views
{
    enum TrybOkienka
    {
        Edycja,
        Tworzenie
    }

    public partial class FrmSzczegoly : Form
    {
        ZawodnicyOperation zawodnicyOperation = new ZawodnicyOperation();
        FrmStartowy fs;
        ZawodnikVM zawodnik; // null oznacza tryb dodawania, not null oznacza tryb edycji 

        private TrybOkienka trybOkienka
        {
            get
            {
                if (zawodnik == null)
                    return TrybOkienka.Tworzenie;
                else
                    return TrybOkienka.Edycja;
            }
        }

        public FrmSzczegoly(FrmStartowy fs)
        {
            InitializeComponent();
            this.fs = fs;
        }

        public FrmSzczegoly(FrmStartowy fs, ZawodnikVM z) : this(fs)
        {
            zawodnik = z;
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            
            if(z.DataUrodzenia != null)
                dtpDataUrodzenia.Value = (DateTime)z.DataUrodzenia;
           
            txtWaga.Text = Convert.ToString(z.Waga);
            txtWzrost.Text = Convert.ToString(z.Wzrost);
        }


        private void btnZapisz_Click(object sender, EventArgs e)
        {
            ZawodnikVM zv = new ZawodnikVM()
            {
                Imie = txtImie.Text,
                Nazwisko = txtNazwisko.Text,
                Kraj = txtKraj.Text,
                DataUrodzenia = dtpDataUrodzenia.Value,
                Waga = Convert.ToInt32(txtWaga.Text),
                Wzrost = Convert.ToInt32(txtWzrost.Text)
            };

            if (trybOkienka == TrybOkienka.Tworzenie)
            {
                zawodnicyOperation.DodajZawodnika(zv);
            }else if(trybOkienka == TrybOkienka.Edycja)
            {
                zv.Id = zawodnik.Id;
                zawodnicyOperation.EdytujZawodnika(zv);
            }
            else
                throw new Exception("Nieznany tryb otwarcia okienka");
           

            this.Close();
            fs.OdswiezDane();       
        }

        private void FrmSzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            fs.FrmSzczegoly = null;
        }
    }
}
