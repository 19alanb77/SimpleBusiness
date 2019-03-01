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
    public partial class Magazyn : MetroForm
    {
        public Magazyn()
        {
            InitializeComponent();
            loadProduktyListBox();
        }

        public void loadProduktyListBox()
        {
            var produkt = Connections.Methods.getProdukty();
            listBoxProdukty.Font = new Font(FontFamily.GenericMonospace, 10);
            listBoxProdukty.Items.Add("ID" + przerwa(3,"ID") + "Nazwa Produktu" + przerwa(18,"Nazwa Produktu") + "Ilość" + przerwa(13,"Ilość") + "Cena Detaliczna" + przerwa(16,"Cena Detaliczna") + "Cena Hurtowa" + przerwa(15,"Cena Hurtowa") + "Nazwa Kategorii" + przerwa(17,"Nazwa Kategorii") + "Data Ważności");
            foreach (var x in produkt)
            {
                String text = x.IdProduktu.ToString() + przerwa(3,x.IdProduktu.ToString()) + x.NazwaProduktu + przerwa(18,x.NazwaProduktu) + (x.Ilosc.ToString()+" sztuk ") + przerwa(6,x.Ilosc.ToString()) + (x.CenaDetaliczna.ToString()+ " zł ") + przerwa(12,x.CenaDetaliczna.ToString()) + (x.CenaHurtowa.ToString() + " zł ") + przerwa(11, x.CenaHurtowa.ToString()) + x.NazwaKategorii + przerwa(17,x.NazwaKategorii) + x.DataWaznosci.Substring(0,10); 
                listBoxProdukty.Items.Add(text);
            }
        }

        public void loadWedlugKategorii(string kategoria)
        {
            listBoxProdukty.Items.Clear();
            listBoxProdukty.Font = new Font(FontFamily.GenericMonospace, 10);
            listBoxProdukty.Items.Add("ID" + przerwa(3, "ID") + "Nazwa Produktu" + przerwa(18, "Nazwa Produktu") + "Ilość" + przerwa(13, "Ilość") + "Cena Detaliczna" + przerwa(16, "Cena Detaliczna") + "Cena Hurtowa" + przerwa(15, "Cena Hurtowa") + "Nazwa Kategorii" + przerwa(17, "Nazwa Kategorii") + "Data Ważności");
            var produkt = Connections.Methods.getProdukty();
            foreach (var x in produkt)
            {
                if (x.NazwaKategorii.Equals(kategoria))
                {
                    String text = x.IdProduktu.ToString() + przerwa(3, x.IdProduktu.ToString()) + x.NazwaProduktu + przerwa(18, x.NazwaProduktu) + (x.Ilosc.ToString() + " sztuk ") + przerwa(6, x.Ilosc.ToString()) + (x.CenaDetaliczna.ToString() + " zł ") + przerwa(12, x.CenaDetaliczna.ToString()) + (x.CenaHurtowa.ToString() + " zł ") + przerwa(11, x.CenaHurtowa.ToString()) + x.NazwaKategorii + przerwa(17, x.NazwaKategorii) + x.DataWaznosci.Substring(0, 10);
                    listBoxProdukty.Items.Add(text);
                }
                
            } 
        }

        public void dodajProdukt(string nazwa, float ilosc, float cenaDetaliczna, float cenaHurtowa, string nazwaKategorii, string dataWaznosci)
        {
            Connections.Methods.dodajProdukt(nazwa,ilosc,cenaDetaliczna,cenaHurtowa,nazwaKategorii,dataWaznosci);
            Magazyn magazyn = new Magazyn();
            magazyn.Show();
            loadProduktyListBox();
        }

        public void zwiekszProdukt(string produkt, float ilosc)
        {
            Connections.Methods.zwiekszProdukt(produkt, ilosc);
            Magazyn magazyn = new Magazyn();
            magazyn.Show();
            loadProduktyListBox();
        }

        public void usunProdukt(string produkt, float ilosc)
        {
            Connections.Methods.usunProdukt(produkt, ilosc);
            Magazyn magazyn = new Magazyn();
            magazyn.Show();
            loadProduktyListBox();
        }

        private void metroButtonDodajProdukt_Click(object sender, EventArgs e)
        {
            DodajProdukt dodajProduktWindow = new DodajProdukt();
            dodajProduktWindow.Show();
            this.Hide();
            dodajProduktWindow.Closed += (s, args) => this.Close();
        }

        private void metroButtonUsunProdukt_Click(object sender, EventArgs e)
        {
            UsunProdukt usunProduktWindow = new UsunProdukt();
            usunProduktWindow.Show();
            this.Hide();
            usunProduktWindow.Closed += (s, args) => this.Close();
        }

        private void metroButtonZwiekszProdukt_Click(object sender, EventArgs e)
        {
            ZwiekszProdukt zwiekszProduktWindow = new ZwiekszProdukt();
            zwiekszProduktWindow.Show();
            this.Hide();
            zwiekszProduktWindow.Closed += (s, args) => this.Close();
        }

        private void metroButtonKrotkaWaznosc_Click(object sender, EventArgs e)
        {
            listBoxProdukty.Items.Clear();
            listBoxProdukty.Font = new Font(FontFamily.GenericMonospace, 10);
            listBoxProdukty.Items.Add("ID" + przerwa(3, "ID") + "Nazwa Produktu" + przerwa(18, "Nazwa Produktu") + "Ilość" + przerwa(13, "Ilość") + "Cena Detaliczna" + przerwa(16, "Cena Detaliczna") + "Cena Hurtowa" + przerwa(15, "Cena Hurtowa") + "Nazwa Kategorii" + przerwa(17, "Nazwa Kategorii") + "Data Ważności");
            var produkt = Connections.Methods.krotkaWaznosc();
            foreach (var x in produkt)
            {
                String text = x.IdProduktu.ToString() + przerwa(3, x.IdProduktu.ToString()) + x.NazwaProduktu + przerwa(18, x.NazwaProduktu) + (x.Ilosc.ToString() + " sztuk ") + przerwa(6, x.Ilosc.ToString()) + (x.CenaDetaliczna.ToString() + " zł ") + przerwa(12, x.CenaDetaliczna.ToString()) + (x.CenaHurtowa.ToString() + " zł ") + przerwa(11, x.CenaHurtowa.ToString()) + x.NazwaKategorii + przerwa(17, x.NazwaKategorii) + x.DataWaznosci.Substring(0, 10);
                listBoxProdukty.Items.Add(text);
            }
        }

        private void metroButtonWedlugKategorii_Click(object sender, EventArgs e)
        {
            WedlugKategorii wedlugKategoriiWindow = new WedlugKategorii();
            this.Hide();
            wedlugKategoriiWindow.Show();
            wedlugKategoriiWindow.Closed += (s, args) => this.Close();
        }

        private void metroButtonZarobek_Click(object sender, EventArgs e)
        {
            listBoxProdukty.Items.Clear();
            listBoxProdukty.Font = new Font(FontFamily.GenericMonospace, 10);
            listBoxProdukty.Items.Add("ID" + przerwa(3, "ID") + "Nazwa Produktu" + przerwa(18, "Nazwa Produktu") + "Ilość" + przerwa(13, "Ilość") + "Cena Detaliczna" + przerwa(16, "Cena Detaliczna") + "Cena Hurtowa" + przerwa(15, "Cena Hurtowa") + "Nazwa Kategorii" + przerwa(17, "Nazwa Kategorii") + "Data Ważności");
            var produkt = Connections.Methods.najwiekszyZarobek();
            foreach (var x in produkt)
            {
                String text = x.IdProduktu.ToString() + przerwa(3, x.IdProduktu.ToString()) + x.NazwaProduktu + przerwa(18, x.NazwaProduktu) + (x.Ilosc.ToString() + " sztuk ") + przerwa(6, x.Ilosc.ToString()) + (x.CenaDetaliczna.ToString() + " zł ") + przerwa(12, x.CenaDetaliczna.ToString()) + (x.CenaHurtowa.ToString() + " zł ") + przerwa(11, x.CenaHurtowa.ToString()) + x.NazwaKategorii + przerwa(17, x.NazwaKategorii) + x.DataWaznosci.Substring(0, 10);
                listBoxProdukty.Items.Add(text);
            }
        }

        private string przerwa(int maxWidth, string element)
        {
            string wynik = "";
            for(int i = 0; i < (maxWidth - (element.Length)); i++)
            {
                wynik += " "; 
            }
            return wynik;
        }

        private void buttonUsunProdukt_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajProdukt_Click(object sender, EventArgs e)
        {

        }

        private void listBoxProdukty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonZwiekszTowar_Click(object sender, EventArgs e)
        {

        }

        private void buttonKrotkaWaznosc_Click(object sender, EventArgs e)
        {

        }

        private void buttonNajwiekszyZarobek_Click(object sender, EventArgs e)
        {

        }

        private void buttonWgKategorii_Click(object sender, EventArgs e)
        {

        }
    }
}
