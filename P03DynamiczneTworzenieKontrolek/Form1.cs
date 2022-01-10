using P02AplikacjaZawodnicy.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03DynamiczneTworzenieKontrolek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStworzPrzycisk_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Name = "btnNowy";
            b.Text = "nowy przycisk";
            b.Top = 80;
            b.Left = 20;

            Controls.Add(b);

        }

        private void btnWczytajZawodnikow_Click(object sender, EventArgs e)
        {
            ZawodnicyOperation zo = new ZawodnicyOperation();
            var zawodnicy = zo.PodajZawodnikow();
            for (int i = 0; i < zawodnicy.Length; i++)
            {
                Button b = new Button();
                b.Name = $"btnZawodnik{zawodnicy[i].Id}";
                b.Tag = zawodnicy[i].Id;
                b.Top = 20 + i * 20;
                b.Left = 150;
                Controls.Add(b);
                b.Text = $"{zawodnicy[i].Imie} {zawodnicy[i].Nazwisko}";
                b.Click += new System.EventHandler(this.btnOperacja_Click);
            }
        }
        private void btnOperacja_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            int id = (int)przycisk.Tag;

            ZawodnicyOperation zo = new ZawodnicyOperation();
            var z= zo.PodajZawodnika(id);
            MessageBox.Show(z.PodstawoweDane);
        }
    }
}
