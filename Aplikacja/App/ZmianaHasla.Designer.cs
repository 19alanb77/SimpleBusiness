namespace MainApp
{
    partial class ZmianaHasla
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
            this.metroButtonZmien = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxStareHaslo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNoweHaslo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPowtorzHaslo = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButtonZmien
            // 
            this.metroButtonZmien.Location = new System.Drawing.Point(81, 245);
            this.metroButtonZmien.Name = "metroButtonZmien";
            this.metroButtonZmien.Size = new System.Drawing.Size(123, 32);
            this.metroButtonZmien.TabIndex = 7;
            this.metroButtonZmien.Text = "ZMIEŃ";
            this.metroButtonZmien.Click += new System.EventHandler(this.metroButtonZmien_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(83, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Podaj stare hasło";
            // 
            // metroTextBoxStareHaslo
            // 
            this.metroTextBoxStareHaslo.Location = new System.Drawing.Point(80, 72);
            this.metroTextBoxStareHaslo.Name = "metroTextBoxStareHaslo";
            this.metroTextBoxStareHaslo.PasswordChar = '*';
            this.metroTextBoxStareHaslo.Size = new System.Drawing.Size(123, 23);
            this.metroTextBoxStareHaslo.TabIndex = 9;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(80, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Podaj nowe hasło";
            // 
            // metroTextBoxNoweHaslo
            // 
            this.metroTextBoxNoweHaslo.Location = new System.Drawing.Point(80, 131);
            this.metroTextBoxNoweHaslo.Name = "metroTextBoxNoweHaslo";
            this.metroTextBoxNoweHaslo.PasswordChar = '*';
            this.metroTextBoxNoweHaslo.Size = new System.Drawing.Size(124, 23);
            this.metroTextBoxNoweHaslo.TabIndex = 11;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(78, 171);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(125, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Powtórz nowe hasło";
            // 
            // metroTextBoxPowtorzHaslo
            // 
            this.metroTextBoxPowtorzHaslo.Location = new System.Drawing.Point(80, 193);
            this.metroTextBoxPowtorzHaslo.Name = "metroTextBoxPowtorzHaslo";
            this.metroTextBoxPowtorzHaslo.PasswordChar = '*';
            this.metroTextBoxPowtorzHaslo.Size = new System.Drawing.Size(123, 23);
            this.metroTextBoxPowtorzHaslo.TabIndex = 13;
            // 
            // ZmianaHasla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 311);
            this.Controls.Add(this.metroTextBoxPowtorzHaslo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTextBoxNoweHaslo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxStareHaslo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonZmien);
            this.Name = "ZmianaHasla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonZmien;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxStareHaslo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNoweHaslo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPowtorzHaslo;
    }
}