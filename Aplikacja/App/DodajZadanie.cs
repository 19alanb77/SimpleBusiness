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
    public partial class DodajZadanie : MetroForm
    {
        public static string nazwa;
        public static string data;
        public static string tresc;

        public DodajZadanie()
        {
            InitializeComponent();
            loadPracownicy();
        }

        public void loadPracownicy()
        {
            listBoxPracownicy.Font = new Font(FontFamily.GenericMonospace, 8);
            var pracownik = Connections.Methods.GetPracownicyView();
            foreach (var x in pracownik)
            {
                String text = x.Imie + " " + x.Nazwisko;
                listBoxPracownicy.Items.Add(text);
            }
        }

        private void metroButtonDodaj_Click(object sender, EventArgs e)
        {
            nazwa = listBoxPracownicy.SelectedItems[0].ToString();
            data = metroTextBoxData.Text;
            tresc = metroTextBoxTresc.Text;

            Personel personel = new Personel();
            this.Hide();
            personel.dodajZadanie(nazwa, data, tresc);
            personel.Closed += (s, args) => this.Close();
        }


        private void buttonDodajZadanie_Click(object sender, EventArgs e)
        {

        }
    }
}
