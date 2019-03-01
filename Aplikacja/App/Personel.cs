using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using MetroFramework.Forms;
using System.Text.RegularExpressions;

namespace MainApp
{
    public partial class Personel : MetroForm
    {
        public Personel()
        {
            InitializeComponent();
            loadPracownikow();
            loadZadania();
        }

        public void loadPracownikow()
        {
            listBoxPracownicy.Font = new Font(FontFamily.GenericMonospace, 8);
            listBoxPracownicy.Items.Add("ID" + przerwa(3,"ID") + "Imię" + przerwa(10,"Imię") + "Nazwisko" + przerwa(10,"Nazwisko") + "Nazwa Stanowiska" + przerwa(18,"Nazwa Stanowiska") + "PESEL" + przerwa(13,"PESEL") + "Rok Zat." + przerwa(10,"Rok Zat.") + "Zarobki" + przerwa(8,"Zarobki") + " E-mail" + przerwa(30,"E-mail") + "Telefon");
            var pracownik = Connections.Methods.getPracownicy();
            foreach (var x in pracownik)
            {
                String text = x.IdPracownika + przerwa(3,x.IdPracownika.ToString()) + x.Imie + przerwa(10,x.Imie) + x.Nazwisko + przerwa(10,x.Nazwisko) + x.NazwaStanowiska + przerwa(18,x.NazwaStanowiska) + x.PESEL + przerwa(13,x.PESEL) + x.RokZatrudnienia + przerwa(10,x.RokZatrudnienia) + (x.ZarobkiMiesieczne+" zł ") + przerwa(9,x.ZarobkiMiesieczne+" zł ") + x.Email + przerwa(30,x.Email) + x.Telefon;
                listBoxPracownicy.Items.Add(text);
            }
        }

        public void loadZadania()
        {
            listBoxZadania.Font = new Font(FontFamily.GenericMonospace, 8);
            listBoxZadania.Items.Add("Data Wykonania" + przerwa(15,"Data Wykonania") + "Treść" + przerwa(30,"Treść") + "E-mail" + przerwa(30,"E-mail") + "Telefon");
            var zadanie = Connections.Methods.getZadania();
            foreach (var x in zadanie)
            {
                String text = x.DataWykonania.Substring(0, 10) + przerwa(15,x.DataWykonania.Substring(0,10)) + x.Tresc + przerwa(30,x.Tresc) + x.Email + przerwa(30,x.Email) + x.Telefon;
                listBoxZadania.Items.Add(text);
            }
        }

        public void dodajPracownika(string imie, string nazwisko, string nazwaStanowiska, string PESEL, float zarobki, string email, string telefon)
        {
            Connections.Methods.dodajPracownika(imie, nazwisko, nazwaStanowiska, PESEL, zarobki, email, telefon);
            Personel personel = new Personel();
            personel.Show();
            loadPracownikow();
        }

        public void dodajZadanie(string nazwa, string data, string tresc)
        {
            Connections.Methods.dodajZadanie(nazwa, data, tresc);
            Personel personel = new Personel();
            personel.Show();
            loadZadania();
        }

        private void metroButtonDodajPracownika_Click(object sender, EventArgs e)
        {
            DodajPracownika dodajPracownikaWindow = new DodajPracownika();
            dodajPracownikaWindow.Show();
            this.Hide();
            dodajPracownikaWindow.Closed += (s, args) => this.Close();
        }

        private void metroButtonUsunPracownika_Click(object sender, EventArgs e)
        {
            string[] nazwaPracownika = Regex.Replace(listBoxPracownicy.SelectedItems[0].ToString(), @"\s+", " ").Split();
            string x = nazwaPracownika[1] + ' ' + nazwaPracownika[2];

            Connections.Methods.usunPracownika(x);

            Personel personel = new Personel();
            personel.Show();
            this.Hide();
            personel.Closed += (s, args) => this.Close();
        }

        private void metroButtonDodajZadanie_Click(object sender, EventArgs e)
        {
            DodajZadanie dodajZadanieWindow = new DodajZadanie();
            dodajZadanieWindow.Show();
            this.Hide();
            dodajZadanieWindow.Closed += (s, args) => this.Close();
        }

        private void metroButtonUsunZadanie_Click(object sender, EventArgs e)
        {
            string[] nazwaZadania = Regex.Replace(listBoxZadania.SelectedItems[0].ToString(), @"\s+", " ").Split();
            string x = "";
            for (int i = 1; i < ((nazwaZadania.Length) - 2); i++)
            {
                x += nazwaZadania[i] + " ";
            }
            Connections.Methods.usunZadanie(x);

            Personel personel = new Personel();
            personel.Show();
            this.Hide();
            personel.Closed += (s, args) => this.Close(); 
        }

        private void metroButtonEmail_Click(object sender, EventArgs e)
        {
            string lista = Regex.Replace(listBoxZadania.SelectedItems[0].ToString(), @"\s+"," ");
            string[] tresc = lista.Split();
            string adresat = tresc[(tresc.Length) - 2];
            string wiadomosc = "";
            for (int i = 0; i < ((tresc.Length) - 2); i++)
            {
                wiadomosc += tresc[i] + " ";
            }
            
            MailMessage mail = new MailMessage("pinzynierska947@gmail.com", adresat);
            mail.Subject = "Zadanie do wykonania";
            mail.Body = wiadomosc;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

            smtpClient.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "pinzynierska947@gmail.com",
                Password = "praca12345"
            };

            smtpClient.EnableSsl = true;
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                    System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                    System.Security.Cryptography.X509Certificates.X509Chain chain,
                    System.Net.Security.SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };

            smtpClient.Send(mail); 
        }

        private void metroButtonSMS_Click(object sender, EventArgs e)
        {
            // Find your Account Sid and Token at twilio.com/console
            const string accountSid = "ACebc31877921a83eff350ccd6ae519be4";
            const string authToken = "67239e48c0fee9e1650ad05096782c1f";

            TwilioClient.Init(accountSid, authToken);

            string lista = Regex.Replace(listBoxZadania.SelectedItems[0].ToString(), @"\s+", " ");
            string[] tresc = lista.Split();
            string wiadomosc = "";
            for (int i = 0; i < ((tresc.Length) - 2); i++)
            {
                wiadomosc += tresc[i] + " ";
            }
            var message = MessageResource.Create(
                body: wiadomosc,
                from: new Twilio.Types.PhoneNumber("+48732483780"),
                to: new Twilio.Types.PhoneNumber(tresc.Last())
            );

            Console.WriteLine(message.Sid); 
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

        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {

        }

        private void buttonUsunPracownika_Click(object sender, EventArgs e)
        {

        }

        private void buttonDodajZadanie_Click(object sender, EventArgs e)
        {

        }

        private void buttonUsunZadanie_Click(object sender, EventArgs e)
        {

        }

        private void buttonWyslijEmail_Click(object sender, EventArgs e)
        {

        }

        private void buttonSMS_Click(object sender, EventArgs e)
        {


        }
    }
}
