using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO
{
    public class Muntaber : Penyakit
    {
        public override string analisisGejala(string nama, string usia)
        {
            string result = "Analisis Gejala pada pasien " + nama + " (" + usia + "tahun), berdasarkan gejala, " +
                " anda terindikasi mengalami Muntaber. Anda disarankan untuk meminum obat Loperamide. Istirahatlah yang cukup dan semoga" +
                " cepat sembuh";
            return result;
        }
    }
}
