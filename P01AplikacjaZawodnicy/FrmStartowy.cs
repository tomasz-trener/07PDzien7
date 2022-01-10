using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01AplikacjaZawodnicy
{
    public partial class FrmStartowy : Form
    {
        public FrmStartowy()
        {
            InitializeComponent();
        }

        public Label LblWynik
        {
            get { return lblWynik; }
        }

        private void btnPokazSzczegoly_Click(object sender, EventArgs e)
        {
            string tekst = txtNapis.Text;
            FrmSzczegoly fs = new FrmSzczegoly(tekst,this);
            fs.Show();
        }
    }
}
