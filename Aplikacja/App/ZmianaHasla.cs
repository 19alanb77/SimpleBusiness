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
    public partial class ZmianaHasla : MetroForm
    {
        public ZmianaHasla()
        {
            InitializeComponent();
        }

        private void metroButtonZmien_Click(object sender, EventArgs e)
        {
            String stareHaslo = metroTextBoxStareHaslo.Text;
            String noweHaslo = metroTextBoxNoweHaslo.Text;
            String powtorzHaslo = metroTextBoxPowtorzHaslo.Text;

            var wynik = Connections.Methods.zmienHaslo(stareHaslo, noweHaslo, powtorzHaslo);
            if (wynik.ToString().Equals("1"))
            {
                this.Hide();
                Main mainWindow = new Main();
                mainWindow.Closed += (s, args) => this.Close();
            }
            else
            {
                ZleStareHaslo zleStareHasloWindow = new ZleStareHaslo();
                zleStareHasloWindow.Show();
            }
        }

        private void buttonZmienHaslo_Click(object sender, EventArgs e)
        {

        }
    }
}
