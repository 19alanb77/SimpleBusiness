using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MainApp
{
    public partial class SzczegolyFaktury : MetroForm
    {

        public SzczegolyFaktury()
        {
            InitializeComponent();
            loadFaktury();
        }

        public void loadFaktury()
        {
            listBoxFaktury.Font = new Font(FontFamily.GenericMonospace, 8);
            listBoxFaktury.Items.Add("ID" + przerwa(3, "ID") + "Numer Faktury" + przerwa(15, "Numer Faktury") + "Imię" + przerwa(10, "Imię") + "Nazwisko" + przerwa(10, "Nazwisko") + "Data Wystawienia" + przerwa(18, "Data Wystawienia") + "Kwota Netto" + przerwa(13, "Kwota Netto") + "Kwota VAT" + przerwa(11, "Kwota VAT") + "Kwota Brutto" + przerwa(14, "Kwota Brutto") + "Zysk" + przerwa(8, "Zysk") + "Nazwa Nabywcy" + przerwa(17, "Nazwa Nabywcy"));
            var faktura = Connections.Methods.getFaktury();
            foreach (var x in faktura)
            {
                String text = x.IdFaktury + przerwa(3, x.IdFaktury.ToString()) + x.NumerFaktury + przerwa(15, x.NumerFaktury) + x.Imie + przerwa(10, x.Imie) + x.Nazwisko + przerwa(10, x.Nazwisko) + x.DataWystawienia.Substring(0, 10) + przerwa(18, x.DataWystawienia.Substring(0, 10)) + x.KwotaNetto + " zł " + przerwa(9, x.KwotaNetto.ToString()) + x.KwotaVAT + " zł " + przerwa(5, x.KwotaVAT.ToString()) + x.KwotaBrutto + " zł " + przerwa(10, x.KwotaBrutto.ToString()) + x.Zysk + " zł " + przerwa(4, x.Zysk.ToString()) + x.NazwaNabywcy + przerwa(17, x.NazwaNabywcy);
                listBoxFaktury.Items.Add(text);
            }
        }

        public void loadSzczegoly(string numerFaktury)
        {
            listBoxSzczegolyFaktury.Items.Clear();
            listBoxSzczegolyFaktury.Font = new Font(FontFamily.GenericMonospace, 8);
            listBoxSzczegolyFaktury.Items.Add("ID" + przerwa(3,"ID") + "Numer Faktury" + przerwa(15,"Numer Faktury") + "Nazwa Produktu" + przerwa(15,"Nazwa Produktu") + "Ilość" + przerwa(10,"Ilość") + "Kwota Netto" + przerwa(13,"Kwota Netto") + "Kwota VAT" + przerwa(11,"Kwota VAT") + "Kwota Brutto" + przerwa(13,"Kwota Brutto") + "Zysk");
            var faktura = Connections.Methods.getSzczegolyFaktur();
            foreach (var x in faktura)
            {
                   if (x.NumerFaktury.Equals(numerFaktury))
                   {
                    String text = x.NumerId + przerwa(3,x.NumerId.ToString()) + x.NumerFaktury + przerwa(15,x.NumerFaktury) + x.NazwaProduktu + przerwa(15,x.NazwaProduktu) + x.Ilosc + " sztuk " + przerwa(3,x.Ilosc.ToString()) + x.KwotaNetto + " zł " + przerwa(9,x.KwotaNetto.ToString()) + x.KwotaVAT + " zł " + przerwa(7,x.KwotaVAT.ToString()) + x.KwotaBrutto + " zł " + przerwa(9,x.KwotaBrutto.ToString()) + x.Zysk + " zł";
                    listBoxSzczegolyFaktury.Items.Add(text);
                    }
            } 
        }

        private void metroButtonSzczegoly_Click(object sender, EventArgs e)
        {
            string[] numerFaktury = Regex.Replace(listBoxFaktury.SelectedItems[0].ToString(), @"\s+", " ").Split(' ');
            loadSzczegoly(numerFaktury[1]);
        }

        private void metroButtonUsunProdukt_Click(object sender, EventArgs e)
        {
            string nazwaProduktu = "";
            string lista = Regex.Replace(listBoxSzczegolyFaktury.SelectedItems[0].ToString(), @"\s+", " ");
            string[] numer = lista.Split(' ');
            for (int i = 2; i < ((numer.Length) - 10); i++)
            {
                nazwaProduktu += numer[i] + " ";
            }
                   Connections.Methods.usunSzczegolyFaktury(nazwaProduktu, numer[1],float.Parse(numer[numer.Length-10]));
                   SzczegolyFaktury szczegolyWindow = new SzczegolyFaktury();
                   szczegolyWindow.Show();
                   this.Hide();
                   szczegolyWindow.Closed += (s, args) => this.Close();   
        }

        private string przerwa(int maxWidth, string element)
        {
            string wynik = "";
            for (int i = 0; i < (maxWidth - (element.Length)); i++)
            {
                wynik += " ";
            }
            return wynik;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSzczegoly_Click(object sender, EventArgs e)
        {

        }

        private void buttonUsunProdukt_Click(object sender, EventArgs e)
        {

        }

        private void SzczegolyFaktury_Load(object sender, EventArgs e)
        {

        }
    }
}
