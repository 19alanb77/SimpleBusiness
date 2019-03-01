using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FakturaView
    {
        public int IdFaktury { get; set; }
        public string NumerFaktury { get; set; }
        public string Imie { get; set; }
        public string DataWystawienia { get; set; }
        public float KwotaNetto { get; set; }
        public float KwotaVAT { get; set; }
        public float KwotaBrutto { get; set; }
    }
}
