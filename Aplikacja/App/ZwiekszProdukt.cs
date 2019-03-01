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
    public partial class ZwiekszProdukt : MetroForm
    {
        public static string produkt;
        public static float ilosc;

        public ZwiekszProdukt()
        {
            InitializeComponent();
            loadProdukty();
        }

        public void loadProdukty()
        {
            listBoxProdukt.Font = new Font(FontFamily.GenericMonospace, 8);
            var produkt = Connections.Methods.getProdukty();
            foreach (var x in produkt)
            {
                String text = x.NazwaProduktu;
                listBoxProdukt.Items.Add(text);
            }
        }

        private void metroButtonDodaj_Click(object sender, EventArgs e)
        {
            produkt = listBoxProdukt.SelectedItems[0].ToString();
            ilosc = float.Parse(metroTextBoxIlosc.Text);
            Magazyn magazyn = new Magazyn();
            this.Hide();
            magazyn.zwiekszProdukt(produkt, ilosc);
            magazyn.Closed += (s, args) => this.Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {

        }
    }
}
