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
    public partial class RiwayatForm : Form
    {
        public RiwayatForm()
        {
            InitializeComponent();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            lblNama1.Text = "-";
            lblUsia1.Text = "-";
            tbHasil.Text = "-";
            using (var db = new RiwayatModel())
            {
                var query = from table in db.Tables where table.Nama == tbCari.Text select table;
                foreach(var item in query)
                {
                    lblNama1.Text = item.Nama;
                    lblUsia1.Text = item.Usia;
                    tbHasil.Text = item.Analisis;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
