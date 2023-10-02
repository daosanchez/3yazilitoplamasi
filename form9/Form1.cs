using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Sinav1 = Convert.ToInt32(txtsinav1.Text);
            int Sinav2 = Convert.ToInt32(txtsinav2.Text);
            int Sinav3 = Convert.ToInt32(txtsinav3.Text);
            int ortalama = (Sinav1 + Sinav2 + Sinav3) / 3;
            lblSonuc.Text = "Sonuc: " + ortalama.ToString();
        }

        private void txtsinav1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
