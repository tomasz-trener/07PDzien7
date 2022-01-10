using P02AplikacjaZawodnicy.Operations;
using P02AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace P02AplikacjaZawodnicy.Views
{
    public partial class FrmStartowy : Form
    {
        ZawodnicyOperation zawodnicyOperation = new ZawodnicyOperation();
        FrmSzczegoly fs;

        public FrmSzczegoly FrmSzczegoly
        {
            get { return fs; }
            set { fs = value; }
        }

        public FrmStartowy()
        {
            InitializeComponent();
        }

        public void OdswiezDane()
        {
            zawodnicyOperation = new ZawodnicyOperation();
            var zawodnicy = zawodnicyOperation.PodajZawodnikow();

            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "PodstawoweDane";
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            OdswiezDane();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            zawodnicyOperation.WygenerujRaportPDF();
        }

        private void btnStrona_Click(object sender, EventArgs e)
        { 
            // string sciezka = System.Reflection.Assembly.GetEntryAssembly().Location; // razem z nazwą pliku
            string sciezka = Application.StartupPath;
            
            webBrowser1.Navigate(sciezka + "\\HelloWorld.pdf");
        }

        private void btnWygenerujPodsumowanie_Click(object sender, EventArgs e)
        {
            chartZawodnicy.Series.Clear();

            Series seria = new Series("wzrost");
            seria.ChartType = SeriesChartType.Column;

            var dw =  zawodnicyOperation.WygenerujDaneDoWykresu();

            seria.Points.DataBindXY(dw.X, dw.Y);
            chartZawodnicy.Series.Add(seria);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (fs == null)
            {
                fs = new FrmSzczegoly(this);
                fs.Show();
            }
            
        }
    }
}
