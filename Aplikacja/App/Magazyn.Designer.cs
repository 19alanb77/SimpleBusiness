namespace MainApp
{
    partial class Magazyn
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
            this.listBoxProdukty = new System.Windows.Forms.ListBox();
            this.metroButtonDodajProdukt = new MetroFramework.Controls.MetroButton();
            this.metroButtonUsunProdukt = new MetroFramework.Controls.MetroButton();
            this.metroButtonZwiekszProdukt = new MetroFramework.Controls.MetroButton();
            this.metroButtonKrotkaWaznosc = new MetroFramework.Controls.MetroButton();
            this.metroButtonWedlugKategorii = new MetroFramework.Controls.MetroButton();
            this.metroButtonZarobek = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBoxProdukty
            // 
            this.listBoxProdukty.FormattingEnabled = true;
            this.listBoxProdukty.Location = new System.Drawing.Point(23, 30);
            this.listBoxProdukty.Name = "listBoxProdukty";
            this.listBoxProdukty.Size = new System.Drawing.Size(793, 173);
            this.listBoxProdukty.TabIndex = 0;
            this.listBoxProdukty.SelectedIndexChanged += new System.EventHandler(this.listBoxProdukty_SelectedIndexChanged);
            // 
            // metroButtonDodajProdukt
            // 
            this.metroButtonDodajProdukt.Location = new System.Drawing.Point(228, 209);
            this.metroButtonDodajProdukt.Name = "metroButtonDodajProdukt";
            this.metroButtonDodajProdukt.Size = new System.Drawing.Size(161, 42);
            this.metroButtonDodajProdukt.TabIndex = 7;
            this.metroButtonDodajProdukt.Text = "DODAJ NOWY PRODUKT";
            this.metroButtonDodajProdukt.Click += new System.EventHandler(this.metroButtonDodajProdukt_Click);
            // 
            // metroButtonUsunProdukt
            // 
            this.metroButtonUsunProdukt.Location = new System.Drawing.Point(421, 209);
            this.metroButtonUsunProdukt.Name = "metroButtonUsunProdukt";
            this.metroButtonUsunProdukt.Size = new System.Drawing.Size(161, 42);
            this.metroButtonUsunProdukt.TabIndex = 8;
            this.metroButtonUsunProdukt.Text = "USUŃ PRODUKT";
            this.metroButtonUsunProdukt.Click += new System.EventHandler(this.metroButtonUsunProdukt_Click);
            // 
            // metroButtonZwiekszProdukt
            // 
            this.metroButtonZwiekszProdukt.Location = new System.Drawing.Point(228, 257);
            this.metroButtonZwiekszProdukt.Name = "metroButtonZwiekszProdukt";
            this.metroButtonZwiekszProdukt.Size = new System.Drawing.Size(161, 42);
            this.metroButtonZwiekszProdukt.TabIndex = 9;
            this.metroButtonZwiekszProdukt.Text = "ZWIĘKSZ ILOŚĆ PRODUKTU";
            this.metroButtonZwiekszProdukt.Click += new System.EventHandler(this.metroButtonZwiekszProdukt_Click);
            // 
            // metroButtonKrotkaWaznosc
            // 
            this.metroButtonKrotkaWaznosc.Location = new System.Drawing.Point(421, 257);
            this.metroButtonKrotkaWaznosc.Name = "metroButtonKrotkaWaznosc";
            this.metroButtonKrotkaWaznosc.Size = new System.Drawing.Size(161, 42);
            this.metroButtonKrotkaWaznosc.TabIndex = 10;
            this.metroButtonKrotkaWaznosc.Text = "KRÓTKA WAŻNOŚĆ";
            this.metroButtonKrotkaWaznosc.Click += new System.EventHandler(this.metroButtonKrotkaWaznosc_Click);
            // 
            // metroButtonWedlugKategorii
            // 
            this.metroButtonWedlugKategorii.Location = new System.Drawing.Point(228, 305);
            this.metroButtonWedlugKategorii.Name = "metroButtonWedlugKategorii";
            this.metroButtonWedlugKategorii.Size = new System.Drawing.Size(161, 42);
            this.metroButtonWedlugKategorii.TabIndex = 11;
            this.metroButtonWedlugKategorii.Text = "WEDŁUG KATEGORII";
            this.metroButtonWedlugKategorii.Click += new System.EventHandler(this.metroButtonWedlugKategorii_Click);
            // 
            // metroButtonZarobek
            // 
            this.metroButtonZarobek.Location = new System.Drawing.Point(421, 305);
            this.metroButtonZarobek.Name = "metroButtonZarobek";
            this.metroButtonZarobek.Size = new System.Drawing.Size(161, 42);
            this.metroButtonZarobek.TabIndex = 12;
            this.metroButtonZarobek.Text = "NAJWIĘKSZY ZYSK";
            this.metroButtonZarobek.Click += new System.EventHandler(this.metroButtonZarobek_Click);
            // 
            // Magazyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 361);
            this.Controls.Add(this.metroButtonZarobek);
            this.Controls.Add(this.metroButtonWedlugKategorii);
            this.Controls.Add(this.metroButtonKrotkaWaznosc);
            this.Controls.Add(this.metroButtonZwiekszProdukt);
            this.Controls.Add(this.metroButtonUsunProdukt);
            this.Controls.Add(this.metroButtonDodajProdukt);
            this.Controls.Add(this.listBoxProdukty);
            this.Name = "Magazyn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProdukty;
        private MetroFramework.Controls.MetroButton metroButtonDodajProdukt;
        private MetroFramework.Controls.MetroButton metroButtonUsunProdukt;
        private MetroFramework.Controls.MetroButton metroButtonZwiekszProdukt;
        private MetroFramework.Controls.MetroButton metroButtonKrotkaWaznosc;
        private MetroFramework.Controls.MetroButton metroButtonWedlugKategorii;
        private MetroFramework.Controls.MetroButton metroButtonZarobek;
    }
}