using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MainApp
{
    public partial class DodajProdukt : MetroForm
    {
        public static string nazwaProduktu;
        public static float ilosc;
        public static float cenaDetaliczna;
        public static float cenaHurtowa;
        public static string kategoriaProduktu;
        public static string dataWaznosci;

        public DodajProdukt()
        {
            InitializeComponent();
            loadKategorieProduktow();
        }

        public void loadKategorieProduktow()
        {
            listBoxKategorieProduktow.Font = new Font(FontFamily.GenericMonospace, 8);
            var kategoria = Connections.Methods.getKategorieProduktow();
            foreach (var x in kategoria)
            {
                String text = x.NazwaKategorii;
                listBoxKategorieProduktow.Items.Add(text);
            }
        }

        private void metroButtonDodajProdukt_Click(object sender, EventArgs e)
        {
            nazwaProduktu = metroTextBoxNazwaProduktu.Text;
            ilosc = float.Parse(metroTextBoxIlosc.Text);
            cenaDetaliczna = float.Parse(metroTextBoxCenaDetaliczna.Text);
            cenaHurtowa = float.Parse(metroTextBoxCenaHurtowa.Text);
            kategoriaProduktu = listBoxKategorieProduktow.SelectedItems[0].ToString();
            dataWaznosci = metroTextBoxDataWaznosci.Text;

            Magazyn magazyn = new Magazyn();
            this.Hide();
            magazyn.dodajProdukt(nazwaProduktu, ilosc, cenaDetaliczna, cenaHurtowa, kategoriaProduktu, dataWaznosci);
            magazyn.Closed += (s, args) => this.Close();
        }

        private void buttonDodajProdukt_Click(object sender, EventArgs e)
        {

        }

    }
}
