using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MainApp
{
    public partial class Faktura : MetroForm
    {

        public Faktura()
        {
            InitializeComponent();
            loadFaktury();
            loadWystawiajacy();
            loadProdukty();
        }

        public void loadFaktury()
        {
            listBoxFaktury.Font = new Font(FontFamily.GenericMonospace, 8);
            listBoxFaktury.Items.Add("ID" + przerwa(3,"ID") + "Numer Faktury" + przerwa(15,"Numer Faktury") + "Imię" + przerwa(10,"Imię") + "Nazwisko" + przerwa(10,"Nazwisko") + "Data Wystawienia" + przerwa(18,"Data Wystawienia") + "Kwota Netto" + przerwa(13,"Kwota Netto") + "Kwota VAT" + przerwa(13,"Kwota VAT") + "Kwota Brutto" + przerwa(14,"Kwota Brutto") + "Zysk" + przerwa(8,"Zysk") + "Nazwa Nabywcy" + przerwa(17,"Nazwa Nabywcy") + " Adres Nabywcy " + " Numer NIP ");
            var faktura = Connections.Methods.getFaktury();
            foreach (var x in faktura)
            {
                String text = x.IdFaktury + przerwa(3,x.IdFaktury.ToString()) + x.NumerFaktury + przerwa(15,x.NumerFaktury) + x.Imie + przerwa(10,x.Imie) + x.Nazwisko + przerwa(10,x.Nazwisko) + x.DataWystawienia.Substring(0,10) + przerwa(18,x.DataWystawienia.Substring(0,10)) + x.KwotaNetto + " zł " + przerwa(9,x.KwotaNetto.ToString()) + x.KwotaVAT + " zł " + przerwa(9,x.KwotaVAT.ToString()) + x.KwotaBrutto + " zł " + przerwa(10,x.KwotaBrutto.ToString()) + x.Zysk + " zł " + przerwa(4,x.Zysk.ToString()) + x.NazwaNabywcy + przerwa(17,x.NazwaNabywcy) + x.AdresNabywcy + x.NumerNIP;
                listBoxFaktury.Items.Add(text);
            }
        }

        public void loadWystawiajacy()
        {
            listBoxWystawiajacy.Font = new Font(FontFamily.GenericMonospace, 8);
            var osoba = Connections.Methods.GetPracownicyView();
            foreach (var x in osoba)
            {
                String text = x.Imie + " " + x.Nazwisko;
                listBoxWystawiajacy.Items.Add(text);
            }
        }

        public void loadProdukty()
        {
            listBoxProdukty.Font = new Font(FontFamily.GenericMonospace, 8);
            var produkt = Connections.Methods.GetProduktyView();
            foreach (var x in produkt)
            {
                String text = x.NazwaProduktu;
                listBoxProdukty.Items.Add(text);
            }
        }

        private static void StworzFakture(string numerFaktury, string dataWystawienia, string wystawiajacy, string nazwaNabywcy, string adresNabywcy, string numerNIP, string kwotaNetto, string kwotaVAT, string kwotaBrutto)
        {
            string bodyFile;
            string template = System.IO.Directory.GetCurrentDirectory() + "\\template.html";
            using (StreamReader reader = new StreamReader(template))
            {
                bodyFile = reader.ReadToEnd();
                bodyFile = bodyFile.Replace("<%numerFaktury%>", numerFaktury);
                bodyFile = bodyFile.Replace("<%dataWystawienia%>", dataWystawienia);
                bodyFile = bodyFile.Replace("<%wystawiajacy%>", wystawiajacy);
                bodyFile = bodyFile.Replace("<%nazwaNabywcy%>", nazwaNabywcy);
                bodyFile = bodyFile.Replace("<%adresNabywcy%>", adresNabywcy);
                bodyFile = bodyFile.Replace("<%numerNIP%>", numerNIP);
                bodyFile = bodyFile.Replace("<%kwotaNetto%>", kwotaNetto);
                bodyFile = bodyFile.Replace("<%kwotaVAT%>", kwotaVAT);
                bodyFile = bodyFile.Replace("<%kwotaBrutto%>", kwotaBrutto);
            }
            FileStream fs = File.OpenWrite(System.IO.Directory.GetCurrentDirectory() + "\\faktura.html");
            StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
            writer.Write(bodyFile);
            writer.Close();
        }


        private void metroButtonDodajDoFaktury_Click(object sender, EventArgs e)
        {
            string numerFaktury = metroTextBoxNumerFaktury.Text;
            string nazwaProduktu = listBoxProdukty.SelectedItems[0].ToString();
            float ilosc = float.Parse(metroTextBoxIlosc.Text);
            float stawkaVAT = float.Parse(metroTextBoxVAT.Text.Replace('.', ','));
            Connections.Methods.dodajDoFaktury(numerFaktury, nazwaProduktu, ilosc, stawkaVAT);
        }

        private void metroButtonDodajFakture_Click(object sender, EventArgs e)
        {
            string numerFaktury = metroTextBoxNumerFaktury.Text;
            string nazwaWystawiajacego = listBoxWystawiajacy.SelectedItems[0].ToString();
            string dataWystawienia = metroTextBoxDataWystawienia.Text;
            string nazwaNabywcy = metroTextBoxNazwaNabywcy.Text;
            string adresNabywcy = metroTextBoxAdres.Text;
            string numerNIP = metroTextBoxNIP.Text;
            Console.WriteLine();
            Connections.Methods.dodajFakture(numerFaktury, nazwaWystawiajacego, dataWystawienia, nazwaNabywcy, adresNabywcy, numerNIP);
            Faktura fakturaWindow = new Faktura();
            fakturaWindow.Show();
            this.Hide();
            fakturaWindow.Closed += (s, args) => this.Close();
        }

        private void metroButtonUsunFakture_Click(object sender, EventArgs e)
        {
            string[] numerFaktury = Regex.Replace(listBoxFaktury.SelectedItems[0].ToString(), @"\s+", " ").Split(' ');
            Connections.Methods.usunFakture(numerFaktury[1]);
            Faktura fakturaWindow = new Faktura();
            fakturaWindow.Show();
            this.Hide();
            fakturaWindow.Closed += (s, args) => this.Close();
        }

        private void metroButtonSzczegoly_Click(object sender, EventArgs e)
        {
            SzczegolyFaktury szczegolyWindow = new SzczegolyFaktury();
            szczegolyWindow.Show();
        }

        private void metroButtonEksportuj_Click(object sender, EventArgs e)
        {
            string adresNabywcy = "";
            string[] dane = null;
            String text = null;
            string[] faktura = Regex.Replace(listBoxFaktury.SelectedItems[0].ToString(), @"\s+", " ").Split(' ');
            var procedura = Connections.Methods.getFaktury();
            foreach (var x in procedura)
            {
                if (x.NumerFaktury.Equals(faktura[1]))
                {
                    text = x.IdFaktury + " "  + x.NumerFaktury + " " + x.Imie + " " + x.Nazwisko + " " + x.DataWystawienia.Substring(0, 10) + " " + x.KwotaNetto + " zł " + " " + x.KwotaVAT + " zł " + " " + x.KwotaBrutto + " zł " + " " + x.Zysk + " zł " + " " + x.NazwaNabywcy + " " + x.AdresNabywcy + " " + x.NumerNIP;
                }              
            }
            dane = text.Split(' ');
            string numerFaktury = dane[1];
            string dataWystawienia = dane[4];
            string wystawiajacy = dane[2] + " " + dane[3];
            string nazwaNabywcy = dane[17] + " " + dane[18];
            for (int i = 19; i < (dane.Length - 1); i++)
            {
                adresNabywcy += dane[i] + " ";
            }

            string numerNIP = dane[dane.Length - 1];
            string kwotaNetto = dane[5];
            string kwotaVAT = dane[8];
            string kwotaBrutto = dane[11];
            StworzFakture(numerFaktury, dataWystawienia, wystawiajacy, nazwaNabywcy, adresNabywcy, numerNIP, kwotaNetto, kwotaVAT, kwotaBrutto);

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

        private void buttonDodajFakture_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajDoFaktury_Click(object sender, EventArgs e)
        {


        }

        private void buttonUsunFakture_Click(object sender, EventArgs e)
        {

        }

        private void buttonSzczegoly_Click(object sender, EventArgs e)
        {

        }

        private void buttonEksportuj_Click(object sender, EventArgs e)
        {

        }

        private void Faktura_Load(object sender, EventArgs e)
        {

        }
    }
}
