using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Faktury
    {
        public int IdFaktury { get; set; }
        public string NumerFaktury { get; set; }
        public int IdWystawiajacego { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Dzien { get; set; }
        public string DataWystawienia{ get; set; }
        public float KwotaNetto { get; set; }
        public float KwotaVAT { get; set; }
        public float KwotaBrutto { get; set; }
        public int IdNabywcy { get; set; }
        public string NazwaNabywcy { get; set; }
        public string AdresNabywcy { get; set; }
        public string NumerNIP { get; set; }
        public float Zysk { get; set; }
    }
}
