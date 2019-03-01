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
    public partial class MenuGlowne : MetroForm
    {
        public MenuGlowne()
        {
            InitializeComponent();
        }

        private void metroButtonMagazyn_Click(object sender, EventArgs e)
        {
            Magazyn magazynWindow = new Magazyn();
            magazynWindow.Show();
        }

        private void metroButtonPersonel_Click(object sender, EventArgs e)
        {
            Personel personelWindow = new Personel();
            personelWindow.Show();
        }

        private void metroButtonStatystyka_Click(object sender, EventArgs e)
        {
            Statystyka statystykaWindow = new Statystyka();
            statystykaWindow.Show();
        }

        private void metroButtonFaktury_Click(object sender, EventArgs e)
        {
            Faktura fakturaWindow = new Faktura();
            fakturaWindow.Show();
        }

        private void buttonMagazyn_Click(object sender, EventArgs e)
        {

        }

        private void buttonPersonel_Click(object sender, EventArgs e)
        {

        }

        private void buttonFaktury_Click(object sender, EventArgs e)
        {

        }

        private void buttonStatystyka_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
