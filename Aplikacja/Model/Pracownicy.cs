using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pracownicy
    {
        public int IdPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NazwaStanowiska { get; set; }
        public string PESEL { get; set; }
        public string RokZatrudnienia { get; set; }
        public float ZarobkiMiesieczne { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}
