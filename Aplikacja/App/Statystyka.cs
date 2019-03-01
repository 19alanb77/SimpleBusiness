using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework.Forms;

namespace MainApp
{
    public partial class Statystyka : MetroForm
    {
        public static string textMiesiac;
        public static string textWartosc;
        public static string text;
        public static string[] Miesiace;
        public static string[] Wartosci;
        public static int dni;

        public Statystyka()
        {
            InitializeComponent();
            loadMiesiacListBox();
            loadChart();
        }

        public void loadChart()
        {
            chart1.Series.Clear();
            var series = new Series("Zysk");
            var zysk = Connections.Methods.getStatystyki();
            foreach (var x in zysk)
            {
                textMiesiac += x.Miesiac + " ";
                textWartosc += x.Zysk + " ";

            }
            Miesiace = textMiesiac.Split(' ');
            Wartosci = textWartosc.Split(' ');
            for(int i = 0; i < (Miesiace.Length-1); i++)
            {
                series.Points.AddXY(Miesiace[i], Wartosci[i]);
            }
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.Series.Add(series);
        }

        public void loadMiesiacListBox()
        {
            var miesiac = Connections.Methods.getMiesiac();
            listBoxMiesiac.Font = new Font(FontFamily.GenericMonospace, 10);
            foreach (var x in miesiac)
            {
                    String text = x.Miesiac.ToString();
                    listBoxMiesiac.Items.Add(text);
            }

         }

        private void metroButtonSprawdz_Click(object sender, EventArgs e)
        {
            metroTextBoxPrzychod.Text = Connections.Methods.obliczPrzychod(Int32.Parse(listBoxMiesiac.SelectedIndex.ToString()) +1).First().ToString();
            metroTextBoxWydatki.Text = Connections.Methods.obliczWydatki().First().ToString();
            metroTextBoxDochodBrutto.Text = Connections.Methods.obliczDochodBrutto(float.Parse(metroTextBoxPrzychod.Text), float.Parse(metroTextBoxWydatki.Text)).First().ToString();
            metroTextBoxDochodNetto.Text = Connections.Methods.obliczDochodNetto(float.Parse(metroTextBoxDochodBrutto.Text)).First().ToString();
            
        }

        private void metroButtonZapiszWartosc_Click(object sender, EventArgs e)
        {
            Connections.Methods.dodajStatystki(listBoxMiesiac.SelectedItems[0].ToString(), float.Parse(metroTextBoxDochodNetto.Text));
            Statystyka statystyka = new Statystyka();
            statystyka.Show();
            this.Hide();
            statystyka.Closed += (s, args) => this.Close();
        }

        private void metroButtonRoczny_Click(object sender, EventArgs e)
        {
            textMiesiac = "";
            textWartosc = "";
            loadChart();
        }

        private void metroButtonKwartalny_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            string[] Kwartal = { "I", "II", "III", "IV" };
            var series = new Series("Zysk");
            var zysk = Connections.Methods.getStatystyki();
            foreach (var x in zysk)
            {
                text += x.Zysk + " ";
            }
            string[] wartosci = text.Split(' ');
            Wartosci[0] = (float.Parse(wartosci[0]) + float.Parse(wartosci[1]) + float.Parse(wartosci[2])).ToString();
            Wartosci[1] = (float.Parse(wartosci[3]) + float.Parse(wartosci[4]) + float.Parse(wartosci[5])).ToString();
            Wartosci[2] = (float.Parse(wartosci[6]) + float.Parse(wartosci[7]) + float.Parse(wartosci[8])).ToString();
            Wartosci[3] = (float.Parse(wartosci[9]) + float.Parse(wartosci[10]) + float.Parse(wartosci[11])).ToString();

            for (int i = 0; i < 4; i++)
            {
                series.Points.AddXY(Kwartal[i], Wartosci[i]);
            }

            chart1.Series.Add(series);
        }

        private void metroButtonMiesieczny_Click(object sender, EventArgs e)
        {
            int miesiacInt = Int32.Parse(listBoxMiesiac.SelectedIndex.ToString()) + 1;
            dni = DateTime.DaysInMonth(2018, miesiacInt);
            chart1.Series.Clear();
          
            string[] Dni = new string[dni];
            int[] Wartosci = new int[dni];
            for (int k = 0; k < dni; k++)
            {
                Wartosci[k] = 0;
            }
            for (int i = 0; i < dni; i++)
            {
                Dni[i] = (i + 1).ToString();
            }
            var series = new Series("Zysk");
            var zysk = Connections.Methods.znajdzDzien(miesiacInt.ToString());
            foreach (var x in zysk)
            {
                    string[] kwota = x.KwotaBrutto.ToString().Split(',');
                    Wartosci[Int32.Parse(x.Dzien) - 1] += Int32.Parse(kwota[0]);
            }

               for (int i = 0; i < dni; i++)
               {
                   series.Points.AddXY(Dni[i], Wartosci[i]);
               }
   
            chart1.Series.Add(series);
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {

        }

        private void buttonSprawdz_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRoczny_Click(object sender, EventArgs e)
        {

        }

        private void buttonKwartalny_Click(object sender, EventArgs e)
        {

        }

        private void buttonMiesieczny_Click(object sender, EventArgs e)
        {

        }

        private void Statystyka_Load(object sender, EventArgs e)
        {

        }
    }
}
