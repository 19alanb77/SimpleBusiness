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
    public partial class UsunProdukt : MetroForm
    {
        public static string produkt;
        public static float ilosc;

        public UsunProdukt()
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

        private void metroButtonUsun_Click(object sender, EventArgs e)
        {
            produkt = listBoxProdukt.SelectedItems[0].ToString();
            ilosc = float.Parse(metroTextBoxIlosc.Text);
            Magazyn magazyn = new Magazyn();
            this.Hide();
            magazyn.usunProdukt(produkt, ilosc);
            magazyn.Closed += (s, args) => this.Close();
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {

        }
    }
}
