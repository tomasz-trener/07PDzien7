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
    public partial class FrmSzczegoly : Form
    {
        FrmStartowy fs;

        public FrmSzczegoly(string napis, FrmStartowy fs )
        {
            InitializeComponent();

            lblWynik.Text = napis;
            this.fs = fs;
        }

        private void btnPrzekazNapis_Click(object sender, EventArgs e)
        {
            fs.LblWynik.Text = txtNapis.Text;
        }
    }
}
