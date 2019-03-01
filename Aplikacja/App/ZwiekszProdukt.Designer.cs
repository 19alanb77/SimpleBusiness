namespace MainApp
{
    partial class ZwiekszProdukt
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
            this.listBoxProdukt = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxIlosc = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonDodaj = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBoxProdukt
            // 
            this.listBoxProdukt.FormattingEnabled = true;
            this.listBoxProdukt.Location = new System.Drawing.Point(77, 51);
            this.listBoxProdukt.Name = "listBoxProdukt";
            this.listBoxProdukt.Size = new System.Drawing.Size(120, 134);
            this.listBoxProdukt.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(107, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Produkt";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(118, 191);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Ilość";
            // 
            // metroTextBoxIlosc
            // 
            this.metroTextBoxIlosc.Location = new System.Drawing.Point(77, 213);
            this.metroTextBoxIlosc.Name = "metroTextBoxIlosc";
            this.metroTextBoxIlosc.Size = new System.Drawing.Size(120, 23);
            this.metroTextBoxIlosc.TabIndex = 7;
            // 
            // metroButtonDodaj
            // 
            this.metroButtonDodaj.Location = new System.Drawing.Point(77, 255);
            this.metroButtonDodaj.Name = "metroButtonDodaj";
            this.metroButtonDodaj.Size = new System.Drawing.Size(120, 31);
            this.metroButtonDodaj.TabIndex = 8;
            this.metroButtonDodaj.Text = "DODAJ";
            this.metroButtonDodaj.Click += new System.EventHandler(this.metroButtonDodaj_Click);
            // 
            // ZwiekszProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 311);
            this.Controls.Add(this.metroButtonDodaj);
            this.Controls.Add(this.metroTextBoxIlosc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBoxProdukt);
            this.Name = "ZwiekszProdukt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxProdukt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIlosc;
        private MetroFramework.Controls.MetroButton metroButtonDodaj;
    }
}