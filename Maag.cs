using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PBO
{
    public class Maag : Penyakit
    {
        public override string analisisGejala(string nama, string usia)
        {
            string result = "Analisis Gejala pada pasien " + nama + " (" + usia + "tahun), berdasarkan gejala, " +
                " anda terindikasi mengalami Maag. Anda disarankan untuk meminum obat Mylanta. Istirahatlah yang cukup dan semoga" +
                " cepat sembuh";
            return result;
        }
    }
    
}
