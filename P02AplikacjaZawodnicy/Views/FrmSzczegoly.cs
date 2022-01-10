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
    public enum TrybOkienka
    {
        Edycja,
        Tworzenie,
        Usuwanie
    }

    public partial class FrmSzczegoly : Form
    {
        ZawodnicyOperation zawodnicyOperation = new ZawodnicyOperation();
        FrmStartowy fs;
        ZawodnikVM zawodnik; // null oznacza tryb dodawania, not null oznacza tryb edycji 

        private TrybOkienka trybOkienka; 

        public FrmSzczegoly(FrmStartowy fs)
        {
            InitializeComponent();
            this.fs = fs;
            trybOkienka = TrybOkienka.Tworzenie;
            StworzPrzyciskOpcji();
        }

        public FrmSzczegoly(FrmStartowy fs, ZawodnikVM z, TrybOkienka trybOkienka) : this(fs)
        {
            this.trybOkienka = trybOkienka;
            zawodnik = z;
            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            
            if(z.DataUrodzenia != null)
                dtpDataUrodzenia.Value = (DateTime)z.DataUrodzenia;
           
            txtWaga.Text = Convert.ToString(z.Waga);
            txtWzrost.Text = Convert.ToString(z.Wzrost);
            StworzPrzyciskOpcji();


        }

        private void StworzPrzyciskOpcji()
        {
            Button b = new Button();
             
            b.Name = "btnOperacja";
            b.Location = new Point(181, 174);
            b.Size = new Size(75, 23);
            b.Click += new System.EventHandler(this.btnOperacja_Click);
            Controls.Add(b);
            if (trybOkienka == TrybOkienka.Usuwanie)
            {
                txtImie.Enabled = false;
                txtNazwisko.Enabled = false;
                txtKraj.Enabled = false;
                txtWzrost.Enabled = false;
                txtWaga.Enabled = false;
                dtpDataUrodzenia.Enabled = false;
                b.Text = "Usuń";
            }
            else if (trybOkienka == TrybOkienka.Edycja)
            {
                b.Text = "Edytuj";
            }
            else if (trybOkienka == TrybOkienka.Tworzenie)
            {
                b.Text = "Stwórz";
            }
        }

        private void btnOperacja_Click(object sender, EventArgs e)
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
            }
            else if (trybOkienka == TrybOkienka.Edycja)
            {
                zv.Id = zawodnik.Id;
                zawodnicyOperation.EdytujZawodnika(zv);
            }
            else if (trybOkienka == TrybOkienka.Usuwanie)
            {
                DialogResult dr=
                    MessageBox.Show($"Czy napewno chcesz zawodnika {zv.PodstawoweDane} ? ", "Potwierdzenie usunieca",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    zv.Id = zawodnik.Id;
                    zawodnicyOperation.UsunZawodnika(zv);
                }
                else
                    return;                        
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
