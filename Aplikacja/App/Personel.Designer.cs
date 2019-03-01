namespace MainApp
{
    partial class Personel
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
            this.listBoxPracownicy = new System.Windows.Forms.ListBox();
            this.listBoxZadania = new System.Windows.Forms.ListBox();
            this.metroButtonDodajPracownika = new MetroFramework.Controls.MetroButton();
            this.metroButtonUsunPracownika = new MetroFramework.Controls.MetroButton();
            this.metroButtonDodajZadanie = new MetroFramework.Controls.MetroButton();
            this.metroButtonUsunZadanie = new MetroFramework.Controls.MetroButton();
            this.metroButtonSMS = new MetroFramework.Controls.MetroButton();
            this.metroButtonEmail = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBoxPracownicy
            // 
            this.listBoxPracownicy.FormattingEnabled = true;
            this.listBoxPracownicy.Location = new System.Drawing.Point(36, 25);
            this.listBoxPracownicy.Name = "listBoxPracownicy";
            this.listBoxPracownicy.Size = new System.Drawing.Size(858, 82);
            this.listBoxPracownicy.TabIndex = 0;
            // 
            // listBoxZadania
            // 
            this.listBoxZadania.FormattingEnabled = true;
            this.listBoxZadania.Location = new System.Drawing.Point(36, 161);
            this.listBoxZadania.Name = "listBoxZadania";
            this.listBoxZadania.Size = new System.Drawing.Size(858, 82);
            this.listBoxZadania.TabIndex = 1;
            // 
            // metroButtonDodajPracownika
            // 
            this.metroButtonDodajPracownika.Location = new System.Drawing.Point(36, 113);
            this.metroButtonDodajPracownika.Name = "metroButtonDodajPracownika";
            this.metroButtonDodajPracownika.Size = new System.Drawing.Size(130, 23);
            this.metroButtonDodajPracownika.TabIndex = 8;
            this.metroButtonDodajPracownika.Text = "DODAJ PRACOWNIKA";
            this.metroButtonDodajPracownika.Click += new System.EventHandler(this.metroButtonDodajPracownika_Click);
            // 
            // metroButtonUsunPracownika
            // 
            this.metroButtonUsunPracownika.Location = new System.Drawing.Point(764, 113);
            this.metroButtonUsunPracownika.Name = "metroButtonUsunPracownika";
            this.metroButtonUsunPracownika.Size = new System.Drawing.Size(130, 23);
            this.metroButtonUsunPracownika.TabIndex = 9;
            this.metroButtonUsunPracownika.Text = "USUŃ PRACOWNIKA";
            this.metroButtonUsunPracownika.Click += new System.EventHandler(this.metroButtonUsunPracownika_Click);
            // 
            // metroButtonDodajZadanie
            // 
            this.metroButtonDodajZadanie.Location = new System.Drawing.Point(36, 249);
            this.metroButtonDodajZadanie.Name = "metroButtonDodajZadanie";
            this.metroButtonDodajZadanie.Size = new System.Drawing.Size(130, 23);
            this.metroButtonDodajZadanie.TabIndex = 10;
            this.metroButtonDodajZadanie.Text = "DODAJ ZADANIE";
            this.metroButtonDodajZadanie.Click += new System.EventHandler(this.metroButtonDodajZadanie_Click);
            // 
            // metroButtonUsunZadanie
            // 
            this.metroButtonUsunZadanie.Location = new System.Drawing.Point(764, 249);
            this.metroButtonUsunZadanie.Name = "metroButtonUsunZadanie";
            this.metroButtonUsunZadanie.Size = new System.Drawing.Size(130, 23);
            this.metroButtonUsunZadanie.TabIndex = 11;
            this.metroButtonUsunZadanie.Text = "USUŃ ZADANIE";
            this.metroButtonUsunZadanie.Click += new System.EventHandler(this.metroButtonUsunZadanie_Click);
            // 
            // metroButtonSMS
            // 
            this.metroButtonSMS.Location = new System.Drawing.Point(519, 294);
            this.metroButtonSMS.Name = "metroButtonSMS";
            this.metroButtonSMS.Size = new System.Drawing.Size(170, 23);
            this.metroButtonSMS.TabIndex = 12;
            this.metroButtonSMS.Text = "WYŚLIJ SMS Z ZADANIEM";
            this.metroButtonSMS.Click += new System.EventHandler(this.metroButtonSMS_Click);
            // 
            // metroButtonEmail
            // 
            this.metroButtonEmail.Location = new System.Drawing.Point(224, 294);
            this.metroButtonEmail.Name = "metroButtonEmail";
            this.metroButtonEmail.Size = new System.Drawing.Size(170, 23);
            this.metroButtonEmail.TabIndex = 13;
            this.metroButtonEmail.Text = "WYŚLIJ E-MAIL Z ZADANIEM";
            this.metroButtonEmail.Click += new System.EventHandler(this.metroButtonEmail_Click);
            // 
            // Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 340);
            this.Controls.Add(this.metroButtonEmail);
            this.Controls.Add(this.metroButtonSMS);
            this.Controls.Add(this.metroButtonUsunZadanie);
            this.Controls.Add(this.metroButtonDodajZadanie);
            this.Controls.Add(this.metroButtonUsunPracownika);
            this.Controls.Add(this.metroButtonDodajPracownika);
            this.Controls.Add(this.listBoxZadania);
            this.Controls.Add(this.listBoxPracownicy);
            this.Name = "Personel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPracownicy;
        private System.Windows.Forms.ListBox listBoxZadania;
        private MetroFramework.Controls.MetroButton metroButtonDodajPracownika;
        private MetroFramework.Controls.MetroButton metroButtonUsunPracownika;
        private MetroFramework.Controls.MetroButton metroButtonDodajZadanie;
        private MetroFramework.Controls.MetroButton metroButtonUsunZadanie;
        private MetroFramework.Controls.MetroButton metroButtonSMS;
        private MetroFramework.Controls.MetroButton metroButtonEmail;
    }
}