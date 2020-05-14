using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO
{
    class Tifus : Penyakit
    {
        public override string analisisGejala(string nama, string usia)
        {
            string result = "Analisis Gejala pada pasien " + nama + " (" + usia + "tahun), berdasarkan gejala, " +
                " anda terindikasi mengalami Tifus. Anda disarankan untuk segera mengunjungi rumah sakit karena penyakit ini harus segera ditangani";
            return result;
        }
    }
}
