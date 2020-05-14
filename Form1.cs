using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_PBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPeriksa_Click(object sender, EventArgs e)
        {
            Periksa periksa = new Periksa();
            periksa.ShowDialog();
        }        

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRiwayat_Click(object sender, EventArgs e)
        {
            RiwayatForm riwayat = new RiwayatForm();
            riwayat.ShowDialog();
        }

        
    }
}
