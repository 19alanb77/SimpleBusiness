namespace MainApp
{
    partial class SzczegolyFaktury
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
            this.listBoxSzczegolyFaktury = new System.Windows.Forms.ListBox();
            this.listBoxFaktury = new System.Windows.Forms.ListBox();
            this.metroButtonUsunProdukt = new MetroFramework.Controls.MetroButton();
            this.metroButtonSzczegoly = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBoxSzczegolyFaktury
            // 
            this.listBoxSzczegolyFaktury.FormattingEnabled = true;
            this.listBoxSzczegolyFaktury.Location = new System.Drawing.Point(12, 162);
            this.listBoxSzczegolyFaktury.Name = "listBoxSzczegolyFaktury";
            this.listBoxSzczegolyFaktury.Size = new System.Drawing.Size(711, 134);
            this.listBoxSzczegolyFaktury.TabIndex = 0;
            this.listBoxSzczegolyFaktury.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxFaktury
            // 
            this.listBoxFaktury.FormattingEnabled = true;
            this.listBoxFaktury.Location = new System.Drawing.Point(12, 23);
            this.listBoxFaktury.Name = "listBoxFaktury";
            this.listBoxFaktury.Size = new System.Drawing.Size(711, 95);
            this.listBoxFaktury.TabIndex = 1;
            // 
            // metroButtonUsunProdukt
            // 
            this.metroButtonUsunProdukt.Location = new System.Drawing.Point(308, 302);
            this.metroButtonUsunProdukt.Name = "metroButtonUsunProdukt";
            this.metroButtonUsunProdukt.Size = new System.Drawing.Size(122, 23);
            this.metroButtonUsunProdukt.TabIndex = 4;
            this.metroButtonUsunProdukt.Text = "USUŃ PRODUKT";
            this.metroButtonUsunProdukt.Click += new System.EventHandler(this.metroButtonUsunProdukt_Click);
            // 
            // metroButtonSzczegoly
            // 
            this.metroButtonSzczegoly.Location = new System.Drawing.Point(308, 124);
            this.metroButtonSzczegoly.Name = "metroButtonSzczegoly";
            this.metroButtonSzczegoly.Size = new System.Drawing.Size(122, 23);
            this.metroButtonSzczegoly.TabIndex = 5;
            this.metroButtonSzczegoly.Text = "SZCZEGÓŁY";
            this.metroButtonSzczegoly.Click += new System.EventHandler(this.metroButtonSzczegoly_Click);
            // 
            // SzczegolyFaktury
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 341);
            this.Controls.Add(this.metroButtonSzczegoly);
            this.Controls.Add(this.metroButtonUsunProdukt);
            this.Controls.Add(this.listBoxFaktury);
            this.Controls.Add(this.listBoxSzczegolyFaktury);
            this.Name = "SzczegolyFaktury";
            this.Load += new System.EventHandler(this.SzczegolyFaktury_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSzczegolyFaktury;
        private System.Windows.Forms.ListBox listBoxFaktury;
        private MetroFramework.Controls.MetroButton metroButtonUsunProdukt;
        private MetroFramework.Controls.MetroButton metroButtonSzczegoly;
    }
}