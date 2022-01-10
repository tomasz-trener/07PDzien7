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
    public partial class FrmSzczegoly : Form
    {
        ZawodnicyOperation zawodnicyOperation = new ZawodnicyOperation();
        FrmStartowy fs;
        public FrmSzczegoly(FrmStartowy fs)
        {
            InitializeComponent();
            this.fs = fs;
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

            zawodnicyOperation.DodajZawodnika(zv);

            this.Close();
            fs.OdswiezDane();       
        }

        private void FrmSzczegoly_FormClosed(object sender, FormClosedEventArgs e)
        {
            fs.FrmSzczegoly = null;
        }
    }
}
