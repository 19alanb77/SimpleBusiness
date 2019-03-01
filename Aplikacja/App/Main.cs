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
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void metroButtonZaloguj_Click(object sender, EventArgs e)
        {
            String haslo = metroTextBoxHaslo.Text;
            var wynik = Connections.Methods.sprawdzHaslo(haslo);

            if (wynik.First().ToString().Equals("1"))
            {
                MenuGlowne menuWindow = new MenuGlowne();
                menuWindow.Show();
                this.Hide();
                menuWindow.Closed += (s, args) => this.Close();
            }
            else
            {
                ZleLogowanie zleLogowanieWindow = new ZleLogowanie();
                zleLogowanieWindow.Show();
            }
        }

        private void metroButtonZmienHaslo_Click(object sender, EventArgs e)
        {
            ZmianaHasla zmianaHaslaWindow = new ZmianaHasla();
            zmianaHaslaWindow.Show();
        }

        private void buttonZaloguj_Click(object sender, EventArgs e)
        {

        }

        private void buttonWybierzZmienHaslo_Click(object sender, EventArgs e)
        {

        }
    }
}
