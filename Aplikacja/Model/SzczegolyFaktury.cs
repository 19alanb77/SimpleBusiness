using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SzczegolyFaktury
    {
        public int NumerId { get; set; }
        public string NumerFaktury { get; set; }
        public string NazwaProduktu { get; set; }
        public float Ilosc { get; set; }
        public float KwotaNetto { get; set; }
        public float KwotaVAT { get; set; }
        public float KwotaBrutto { get; set; }
        public float Zysk { get; set; }
    }
}
