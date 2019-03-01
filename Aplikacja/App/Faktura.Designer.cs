namespace MainApp
{
    partial class Faktura
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
            this.listBoxWystawiajacy = new System.Windows.Forms.ListBox();
            this.listBoxFaktury = new System.Windows.Forms.ListBox();
            this.listBoxProdukty = new System.Windows.Forms.ListBox();
            this.metroButtonDodajDoFaktury = new MetroFramework.Controls.MetroButton();
            this.metroButtonDodajFakture = new MetroFramework.Controls.MetroButton();
            this.metroButtonEksportuj = new MetroFramework.Controls.MetroButton();
            this.metroButtonSzczegoly = new MetroFramework.Controls.MetroButton();
            this.metroButtonUsunFakture = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNumerFaktury = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxVAT = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxNazwaNabywcy = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxAdres = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxNIP = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDataWystawienia = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxIlosc = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // listBoxWystawiajacy
            // 
            this.listBoxWystawiajacy.FormattingEnabled = true;
            this.listBoxWystawiajacy.Location = new System.Drawing.Point(356, 44);
            this.listBoxWystawiajacy.Name = "listBoxWystawiajacy";
            this.listBoxWystawiajacy.Size = new System.Drawing.Size(120, 134);
            this.listBoxWystawiajacy.TabIndex = 9;
            // 
            // listBoxFaktury
            // 
            this.listBoxFaktury.FormattingEnabled = true;
            this.listBoxFaktury.Location = new System.Drawing.Point(34, 337);
            this.listBoxFaktury.Name = "listBoxFaktury";
            this.listBoxFaktury.Size = new System.Drawing.Size(863, 95);
            this.listBoxFaktury.TabIndex = 10;
            // 
            // listBoxProdukty
            // 
            this.listBoxProdukty.FormattingEnabled = true;
            this.listBoxProdukty.Location = new System.Drawing.Point(633, 44);
            this.listBoxProdukty.Name = "listBoxProdukty";
            this.listBoxProdukty.Size = new System.Drawing.Size(120, 134);
            this.listBoxProdukty.TabIndex = 11;
            // 
            // metroButtonDodajDoFaktury
            // 
            this.metroButtonDodajDoFaktury.Location = new System.Drawing.Point(633, 259);
            this.metroButtonDodajDoFaktury.Name = "metroButtonDodajDoFaktury";
            this.metroButtonDodajDoFaktury.Size = new System.Drawing.Size(120, 23);
            this.metroButtonDodajDoFaktury.TabIndex = 24;
            this.metroButtonDodajDoFaktury.Text = "DODAJ DO FAKTURY";
            this.metroButtonDodajDoFaktury.Click += new System.EventHandler(this.metroButtonDodajDoFaktury_Click);
            // 
            // metroButtonDodajFakture
            // 
            this.metroButtonDodajFakture.Location = new System.Drawing.Point(355, 308);
            this.metroButtonDodajFakture.Name = "metroButtonDodajFakture";
            this.metroButtonDodajFakture.Size = new System.Drawing.Size(121, 23);
            this.metroButtonDodajFakture.TabIndex = 25;
            this.metroButtonDodajFakture.Text = "DODAJ FAKTURĘ";
            this.metroButtonDodajFakture.Click += new System.EventHandler(this.metroButtonDodajFakture_Click);
            // 
            // metroButtonEksportuj
            // 
            this.metroButtonEksportuj.Location = new System.Drawing.Point(519, 453);
            this.metroButtonEksportuj.Name = "metroButtonEksportuj";
            this.metroButtonEksportuj.Size = new System.Drawing.Size(120, 23);
            this.metroButtonEksportuj.TabIndex = 26;
            this.metroButtonEksportuj.Text = "EKSPORTUJ DO PLIKU";
            this.metroButtonEksportuj.Click += new System.EventHandler(this.metroButtonEksportuj_Click);
            // 
            // metroButtonSzczegoly
            // 
            this.metroButtonSzczegoly.Location = new System.Drawing.Point(355, 453);
            this.metroButtonSzczegoly.Name = "metroButtonSzczegoly";
            this.metroButtonSzczegoly.Size = new System.Drawing.Size(121, 23);
            this.metroButtonSzczegoly.TabIndex = 27;
            this.metroButtonSzczegoly.Text = "SZCZEGÓŁY";
            this.metroButtonSzczegoly.Click += new System.EventHandler(this.metroButtonSzczegoly_Click);
            // 
            // metroButtonUsunFakture
            // 
            this.metroButtonUsunFakture.Location = new System.Drawing.Point(191, 453);
            this.metroButtonUsunFakture.Name = "metroButtonUsunFakture";
            this.metroButtonUsunFakture.Size = new System.Drawing.Size(121, 23);
            this.metroButtonUsunFakture.TabIndex = 28;
            this.metroButtonUsunFakture.Text = "USUŃ FAKTURĘ";
            this.metroButtonUsunFakture.Click += new System.EventHandler(this.metroButtonUsunFakture_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(44, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "Numer Faktury";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(201, 190);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.TabIndex = 30;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 19);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "Nazwa Nabywcy";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(48, 194);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 32;
            this.metroLabel4.Text = "Adres Nabywcy";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(54, 237);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "NIP Nabywcy";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(367, 22);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 19);
            this.metroLabel6.TabIndex = 34;
            this.metroLabel6.Text = "Wystawiający";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(655, 22);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(55, 19);
            this.metroLabel7.TabIndex = 35;
            this.metroLabel7.Text = "Produkt";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(356, 194);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(111, 19);
            this.metroLabel8.TabIndex = 36;
            this.metroLabel8.Text = "Data Wystawienia";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(676, 194);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(34, 19);
            this.metroLabel9.TabIndex = 37;
            this.metroLabel9.Text = "Ilość";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(54, 79);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(74, 19);
            this.metroLabel10.TabIndex = 38;
            this.metroLabel10.Text = "Stawka VAT";
            // 
            // metroTextBoxNumerFaktury
            // 
            this.metroTextBoxNumerFaktury.Location = new System.Drawing.Point(35, 44);
            this.metroTextBoxNumerFaktury.Name = "metroTextBoxNumerFaktury";
            this.metroTextBoxNumerFaktury.Size = new System.Drawing.Size(120, 23);
            this.metroTextBoxNumerFaktury.TabIndex = 39;
            // 
            // metroTextBoxVAT
            // 
            this.metroTextBoxVAT.Location = new System.Drawing.Point(36, 101);
            this.metroTextBoxVAT.Name = "metroTextBoxVAT";
            this.metroTextBoxVAT.Size = new System.Drawing.Size(120, 23);
            this.metroTextBoxVAT.TabIndex = 40;
            // 
            // metroTextBoxNazwaNabywcy
            // 
            this.metroTextBoxNazwaNabywcy.Location = new System.Drawing.Point(34, 155);
            this.metroTextBoxNazwaNabywcy.Name = "metroTextBoxNazwaNabywcy";
            this.metroTextBoxNazwaNabywcy.Size = new System.Drawing.Size(121, 23);
            this.metroTextBoxNazwaNabywcy.TabIndex = 41;
            // 
            // metroTextBoxAdres
            // 
            this.metroTextBoxAdres.Location = new System.Drawing.Point(36, 216);
            this.metroTextBoxAdres.Name = "metroTextBoxAdres";
            this.metroTextBoxAdres.Size = new System.Drawing.Size(120, 23);
            this.metroTextBoxAdres.TabIndex = 42;
            // 
            // metroTextBoxNIP
            // 
            this.metroTextBoxNIP.Location = new System.Drawing.Point(35, 259);
            this.metroTextBoxNIP.Name = "metroTextBoxNIP";
            this.metroTextBoxNIP.Size = new System.Drawing.Size(120, 23);
            this.metroTextBoxNIP.TabIndex = 43;
            // 
            // metroTextBoxDataWystawienia
            // 
            this.metroTextBoxDataWystawienia.Location = new System.Drawing.Point(356, 216);
            this.metroTextBoxDataWystawienia.Name = "metroTextBoxDataWystawienia";
            this.metroTextBoxDataWystawienia.Size = new System.Drawing.Size(120, 23);
            this.metroTextBoxDataWystawienia.TabIndex = 44;
            // 
            // metroTextBoxIlosc
            // 
            this.metroTextBoxIlosc.Location = new System.Drawing.Point(633, 216);
            this.metroTextBoxIlosc.Name = "metroTextBoxIlosc";
            this.metroTextBoxIlosc.Size = new System.Drawing.Size(120, 23);
            this.metroTextBoxIlosc.TabIndex = 45;
            // 
            // Faktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 499);
            this.Controls.Add(this.metroTextBoxIlosc);
            this.Controls.Add(this.metroTextBoxDataWystawienia);
            this.Controls.Add(this.metroTextBoxNIP);
            this.Controls.Add(this.metroTextBoxAdres);
            this.Controls.Add(this.metroTextBoxNazwaNabywcy);
            this.Controls.Add(this.metroTextBoxVAT);
            this.Controls.Add(this.metroTextBoxNumerFaktury);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonUsunFakture);
            this.Controls.Add(this.metroButtonSzczegoly);
            this.Controls.Add(this.metroButtonEksportuj);
            this.Controls.Add(this.metroButtonDodajFakture);
            this.Controls.Add(this.metroButtonDodajDoFaktury);
            this.Controls.Add(this.listBoxProdukty);
            this.Controls.Add(this.listBoxFaktury);
            this.Controls.Add(this.listBoxWystawiajacy);
            this.Name = "Faktura";
            this.Load += new System.EventHandler(this.Faktura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxWystawiajacy;
        private System.Windows.Forms.ListBox listBoxFaktury;
        private System.Windows.Forms.ListBox listBoxProdukty;
        private MetroFramework.Controls.MetroButton metroButtonDodajDoFaktury;
        private MetroFramework.Controls.MetroButton metroButtonDodajFakture;
        private MetroFramework.Controls.MetroButton metroButtonEksportuj;
        private MetroFramework.Controls.MetroButton metroButtonSzczegoly;
        private MetroFramework.Controls.MetroButton metroButtonUsunFakture;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNumerFaktury;
        private MetroFramework.Controls.MetroTextBox metroTextBoxVAT;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNazwaNabywcy;
        private MetroFramework.Controls.MetroTextBox metroTextBoxAdres;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNIP;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDataWystawienia;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIlosc;
    }
}