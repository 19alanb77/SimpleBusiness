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
    public partial class DodajPracownika : MetroForm
    {
        public static string imie;
        public static string nazwisko;
        public static string nazwaStanowiska;
        public static string PESEL;
        public static float zarobki;
        public static string email;
        public static string telefon;

        public DodajPracownika()
        {
            InitializeComponent();
            loadStanowiska();
        }

        public void loadStanowiska()
        {
            listBoxStanowisko.Font = new Font(FontFamily.GenericMonospace, 8);
            var stanowisko = Connections.Methods.GetStanowiskaView();
            foreach (var x in stanowisko)
            {
                String text = x.NazwaStanowiska;
                listBoxStanowisko.Items.Add(text);
            }
        }

        private void metroButtonDodaj_Click(object sender, EventArgs e)
        {
            imie = metroTextBoxImie.Text;
            nazwisko = metroTextBoxNazwisko.Text;
            nazwaStanowiska = listBoxStanowisko.SelectedItems[0].ToString();
            PESEL = metroTextBoxPESEL.Text;
            zarobki = float.Parse(metroTextBoxZarobki.Text);
            email = metroTextBoxEmail.Text;
            telefon = metroTextBoxTelefon.Text;

            Personel personel = new Personel();
            this.Hide();
            personel.dodajPracownika(imie, nazwisko, nazwaStanowiska, PESEL, zarobki, email,telefon);
            personel.Closed += (s, args) => this.Close();
        }

        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {

        }
    }
}
