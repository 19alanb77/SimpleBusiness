namespace MainApp
{
    partial class DodajZadanie
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonDodaj = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxData = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxTresc = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // listBoxPracownicy
            // 
            this.listBoxPracownicy.FormattingEnabled = true;
            this.listBoxPracownicy.Location = new System.Drawing.Point(58, 181);
            this.listBoxPracownicy.Name = "listBoxPracownicy";
            this.listBoxPracownicy.Size = new System.Drawing.Size(157, 134);
            this.listBoxPracownicy.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(103, 159);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Pracownik";
            // 
            // metroButtonDodaj
            // 
            this.metroButtonDodaj.Location = new System.Drawing.Point(96, 321);
            this.metroButtonDodaj.Name = "metroButtonDodaj";
            this.metroButtonDodaj.Size = new System.Drawing.Size(75, 23);
            this.metroButtonDodaj.TabIndex = 8;
            this.metroButtonDodaj.Text = "DODAJ";
            this.metroButtonDodaj.Click += new System.EventHandler(this.metroButtonDodaj_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(96, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Treść zadania";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(85, 44);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Data wykonania";
            // 
            // metroTextBoxData
            // 
            this.metroTextBoxData.Location = new System.Drawing.Point(58, 66);
            this.metroTextBoxData.Name = "metroTextBoxData";
            this.metroTextBoxData.Size = new System.Drawing.Size(157, 23);
            this.metroTextBoxData.TabIndex = 11;
            // 
            // metroTextBoxTresc
            // 
            this.metroTextBoxTresc.Location = new System.Drawing.Point(33, 124);
            this.metroTextBoxTresc.Name = "metroTextBoxTresc";
            this.metroTextBoxTresc.Size = new System.Drawing.Size(214, 23);
            this.metroTextBoxTresc.TabIndex = 12;
            // 
            // DodajZadanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 356);
            this.Controls.Add(this.metroTextBoxTresc);
            this.Controls.Add(this.metroTextBoxData);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButtonDodaj);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBoxPracownicy);
            this.Name = "DodajZadanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPracownicy;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonDodaj;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxData;
        private MetroFramework.Controls.MetroTextBox metroTextBoxTresc;
    }
}