using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO
{
    class Penyakit_Kronis : Penyakit
    {
        public override string analisisGejala(string nama, string usia)
        {
            string result = "Analisis Gejala pada pasien " + nama + " (" + usia + "tahun), berdasarkan gejala, " +
                " anda terindikasi mengalami penyakit yang kronis. Anda disarankan untuk mengunjungi Dokter untuk konsultasi lebih lanjut";
            return result;
        }
    }
}
