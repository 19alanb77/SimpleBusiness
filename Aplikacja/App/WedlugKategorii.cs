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
    public partial class WedlugKategorii : MetroForm
    {
        public static string kategoria;

        public WedlugKategorii()
        {
            InitializeComponent();
            loadKategorieListBox();
        }

        public void loadKategorieListBox()
        {
            listBoxKategorieProduktow.Font = new Font(FontFamily.GenericMonospace, 8);
            var kategoria = Connections.Methods.getKategorieProduktow();
            foreach (var x in kategoria)
            {
                String text = x.NazwaKategorii;
                listBoxKategorieProduktow.Items.Add(text);
            }
        }

        private void metroButtonWybierz_Click(object sender, EventArgs e)
        {
            kategoria = listBoxKategorieProduktow.SelectedItems[0].ToString();
            Magazyn magazyn = new Magazyn();
            this.Hide();
            magazyn.Show();
            magazyn.loadWedlugKategorii(kategoria);
            magazyn.Closed += (s, args) => this.Close();
        }


        private void buttonKategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
