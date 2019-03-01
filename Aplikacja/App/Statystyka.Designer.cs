namespace MainApp
{
    partial class Statystyka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxMiesiac = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxWydatki = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPrzychod = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDochodNetto = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDochodBrutto = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonSprawdz = new MetroFramework.Controls.MetroButton();
            this.metroButtonZapiszWartosc = new MetroFramework.Controls.MetroButton();
            this.metroButtonRoczny = new MetroFramework.Controls.MetroButton();
            this.metroButtonKwartalny = new MetroFramework.Controls.MetroButton();
            this.metroButtonMiesieczny = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(13, 272);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(748, 177);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // listBoxMiesiac
            // 
            this.listBoxMiesiac.FormattingEnabled = true;
            this.listBoxMiesiac.Location = new System.Drawing.Point(52, 63);
            this.listBoxMiesiac.Name = "listBoxMiesiac";
            this.listBoxMiesiac.Size = new System.Drawing.Size(126, 173);
            this.listBoxMiesiac.TabIndex = 12;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(58, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Wybierz miesiąc";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(283, 41);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Przychód";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(437, 99);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Dochód netto";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(270, 99);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(95, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Dochód brutto";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(455, 41);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Wydatki";
            // 
            // metroTextBoxWydatki
            // 
            this.metroTextBoxWydatki.Location = new System.Drawing.Point(421, 63);
            this.metroTextBoxWydatki.Name = "metroTextBoxWydatki";
            this.metroTextBoxWydatki.Size = new System.Drawing.Size(123, 23);
            this.metroTextBoxWydatki.TabIndex = 23;
            // 
            // metroTextBoxPrzychod
            // 
            this.metroTextBoxPrzychod.Location = new System.Drawing.Point(256, 63);
            this.metroTextBoxPrzychod.Name = "metroTextBoxPrzychod";
            this.metroTextBoxPrzychod.Size = new System.Drawing.Size(123, 23);
            this.metroTextBoxPrzychod.TabIndex = 24;
            // 
            // metroTextBoxDochodNetto
            // 
            this.metroTextBoxDochodNetto.Location = new System.Drawing.Point(421, 133);
            this.metroTextBoxDochodNetto.Name = "metroTextBoxDochodNetto";
            this.metroTextBoxDochodNetto.Size = new System.Drawing.Size(123, 23);
            this.metroTextBoxDochodNetto.TabIndex = 25;
            // 
            // metroTextBoxDochodBrutto
            // 
            this.metroTextBoxDochodBrutto.Location = new System.Drawing.Point(256, 133);
            this.metroTextBoxDochodBrutto.Name = "metroTextBoxDochodBrutto";
            this.metroTextBoxDochodBrutto.Size = new System.Drawing.Size(123, 23);
            this.metroTextBoxDochodBrutto.TabIndex = 26;
            // 
            // metroButtonSprawdz
            // 
            this.metroButtonSprawdz.Location = new System.Drawing.Point(75, 243);
            this.metroButtonSprawdz.Name = "metroButtonSprawdz";
            this.metroButtonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.metroButtonSprawdz.TabIndex = 27;
            this.metroButtonSprawdz.Text = "SPRAWDŹ";
            this.metroButtonSprawdz.Click += new System.EventHandler(this.metroButtonSprawdz_Click);
            // 
            // metroButtonZapiszWartosc
            // 
            this.metroButtonZapiszWartosc.Location = new System.Drawing.Point(334, 179);
            this.metroButtonZapiszWartosc.Name = "metroButtonZapiszWartosc";
            this.metroButtonZapiszWartosc.Size = new System.Drawing.Size(131, 23);
            this.metroButtonZapiszWartosc.TabIndex = 28;
            this.metroButtonZapiszWartosc.Text = "ZAPISZ WARTOŚĆ";
            this.metroButtonZapiszWartosc.Click += new System.EventHandler(this.metroButtonZapiszWartosc_Click);
            // 
            // metroButtonRoczny
            // 
            this.metroButtonRoczny.Location = new System.Drawing.Point(189, 243);
            this.metroButtonRoczny.Name = "metroButtonRoczny";
            this.metroButtonRoczny.Size = new System.Drawing.Size(131, 23);
            this.metroButtonRoczny.TabIndex = 29;
            this.metroButtonRoczny.Text = "WYKRES ROCZNY";
            this.metroButtonRoczny.Click += new System.EventHandler(this.metroButtonRoczny_Click);
            // 
            // metroButtonKwartalny
            // 
            this.metroButtonKwartalny.Location = new System.Drawing.Point(334, 243);
            this.metroButtonKwartalny.Name = "metroButtonKwartalny";
            this.metroButtonKwartalny.Size = new System.Drawing.Size(131, 23);
            this.metroButtonKwartalny.TabIndex = 30;
            this.metroButtonKwartalny.Text = "WYKRES KWARTALNY";
            this.metroButtonKwartalny.Click += new System.EventHandler(this.metroButtonKwartalny_Click);
            // 
            // metroButtonMiesieczny
            // 
            this.metroButtonMiesieczny.Location = new System.Drawing.Point(483, 243);
            this.metroButtonMiesieczny.Name = "metroButtonMiesieczny";
            this.metroButtonMiesieczny.Size = new System.Drawing.Size(138, 23);
            this.metroButtonMiesieczny.TabIndex = 31;
            this.metroButtonMiesieczny.Text = "WYKRES MIESIĘCZNY";
            this.metroButtonMiesieczny.Click += new System.EventHandler(this.metroButtonMiesieczny_Click);
            // 
            // Statystyka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.metroButtonMiesieczny);
            this.Controls.Add(this.metroButtonKwartalny);
            this.Controls.Add(this.metroButtonRoczny);
            this.Controls.Add(this.metroButtonZapiszWartosc);
            this.Controls.Add(this.metroButtonSprawdz);
            this.Controls.Add(this.metroTextBoxDochodBrutto);
            this.Controls.Add(this.metroTextBoxDochodNetto);
            this.Controls.Add(this.metroTextBoxPrzychod);
            this.Controls.Add(this.metroTextBoxWydatki);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBoxMiesiac);
            this.Controls.Add(this.chart1);
            this.Name = "Statystyka";
            this.Load += new System.EventHandler(this.Statystyka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBoxMiesiac;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBoxWydatki;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPrzychod;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDochodNetto;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDochodBrutto;
        private MetroFramework.Controls.MetroButton metroButtonSprawdz;
        private MetroFramework.Controls.MetroButton metroButtonZapiszWartosc;
        private MetroFramework.Controls.MetroButton metroButtonRoczny;
        private MetroFramework.Controls.MetroButton metroButtonKwartalny;
        private MetroFramework.Controls.MetroButton metroButtonMiesieczny;
    }
}