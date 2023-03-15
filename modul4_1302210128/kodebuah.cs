using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210128
{
    internal class kodebuah
    {
        public enum buah
        {
            Apple,
            Aprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung
        }

        public static string getkodebuah(buah nama)
        {
            string[] kodebuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00" };

            return kodebuah[(int)nama];
        }

    }
}
