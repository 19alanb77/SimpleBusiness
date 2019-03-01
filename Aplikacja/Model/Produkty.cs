using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produkty
    {
        public int IdProduktu { get; set; }
        public string NazwaProduktu { get; set; }
        public float Ilosc { get; set; }
        public float CenaDetaliczna { get; set; }
        public float CenaHurtowa { get; set; }
        public string NazwaKategorii { get; set; }
        public int IdKategoriiProduktow { get; set; }
        public string DataWaznosci { get; set; }
    }
}
