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
    public partial class Periksa : Form
    {
        Table table;
        public enum Mode {Insert}
        Mode mode;
        public Periksa()
        {
            InitializeComponent();
            mode = Mode.Insert;
        }

        private void TambahDataRiwayat()
        {
            if (tbNama.Text != "" && tbUsia.Text != "" && tbHasil.Text != "")
            {
                using (var db = new RiwayatModel())
                {
                    table = new Table
                    {
                        Nama = tbNama.Text,
                        Usia = tbUsia.Text,
                        Analisis = tbHasil.Text,
                    };
                    db.Tables.Add(table);
                    db.SaveChanges();
                    MessageBox.Show("Riwayat Ditambahkan");
                }
            }
        }

        private void btnDeteksi_Click(object sender, EventArgs e)
        {           
            if (cbDiare.Checked && cbMuntah.Checked)
            {
                Muntaber muntaber = new Muntaber();
                tbHasil.Text = muntaber.analisisGejala(tbNama.Text, tbUsia.Text);
            }
            else if (cbPusing.Checked && cbLemas.Checked)
            {
                Anemia anemia = new Anemia();
                tbHasil.Text = anemia.analisisGejala(tbNama.Text, tbUsia.Text);
            }
            else if (cbDiare.Checked && cbDemam.Checked && cbLemas.Checked)
            {
                Tifus tifus = new Tifus();
                tbHasil.Text = tifus.analisisGejala(tbNama.Text, tbUsia.Text);
            }
            else if (cbMual.Checked && cbNafsu.Checked)
            {
                Maag maag = new Maag();
                tbHasil.Text = maag.analisisGejala(tbNama.Text, tbUsia.Text);
            }
            else if (cbPenurunanBB.Checked)
            {
                Penyakit_Kronis kronis = new Penyakit_Kronis();
                tbHasil.Text = kronis.analisisGejala(tbNama.Text, tbUsia.Text);
            }
            else
            {
                MessageBox.Show("Maaf kami tidak dapat menganalisis gejala anda");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }       

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                TambahDataRiwayat();
        }
      
    }
}
