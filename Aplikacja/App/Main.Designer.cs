namespace MainApp
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxHaslo = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonZaloguj = new MetroFramework.Controls.MetroButton();
            this.metroButtonZmienHaslo = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 88);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(104, 149);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Podaj login";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(104, 213);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Podaj hasło";
            // 
            // metroTextBoxLogin
            // 
            this.metroTextBoxLogin.BackColor = System.Drawing.Color.White;
            this.metroTextBoxLogin.Location = new System.Drawing.Point(74, 171);
            this.metroTextBoxLogin.Name = "metroTextBoxLogin";
            this.metroTextBoxLogin.Size = new System.Drawing.Size(136, 23);
            this.metroTextBoxLogin.TabIndex = 10;
            this.metroTextBoxLogin.Text = "Administrator";
            // 
            // metroTextBoxHaslo
            // 
            this.metroTextBoxHaslo.Location = new System.Drawing.Point(74, 235);
            this.metroTextBoxHaslo.Name = "metroTextBoxHaslo";
            this.metroTextBoxHaslo.PasswordChar = '*';
            this.metroTextBoxHaslo.Size = new System.Drawing.Size(136, 23);
            this.metroTextBoxHaslo.TabIndex = 11;
            // 
            // metroButtonZaloguj
            // 
            this.metroButtonZaloguj.Location = new System.Drawing.Point(23, 286);
            this.metroButtonZaloguj.Name = "metroButtonZaloguj";
            this.metroButtonZaloguj.Size = new System.Drawing.Size(110, 41);
            this.metroButtonZaloguj.TabIndex = 12;
            this.metroButtonZaloguj.Text = "ZALOGUJ";
            this.metroButtonZaloguj.Click += new System.EventHandler(this.metroButtonZaloguj_Click);
            // 
            // metroButtonZmienHaslo
            // 
            this.metroButtonZmienHaslo.Location = new System.Drawing.Point(151, 286);
            this.metroButtonZmienHaslo.Name = "metroButtonZmienHaslo";
            this.metroButtonZmienHaslo.Size = new System.Drawing.Size(110, 41);
            this.metroButtonZmienHaslo.TabIndex = 13;
            this.metroButtonZmienHaslo.Text = "ZMIEŃ HASŁO";
            this.metroButtonZmienHaslo.Click += new System.EventHandler(this.metroButtonZmienHaslo_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 350);
            this.Controls.Add(this.metroButtonZmienHaslo);
            this.Controls.Add(this.metroButtonZaloguj);
            this.Controls.Add(this.metroTextBoxHaslo);
            this.Controls.Add(this.metroTextBoxLogin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLogin;
        private MetroFramework.Controls.MetroTextBox metroTextBoxHaslo;
        private MetroFramework.Controls.MetroButton metroButtonZaloguj;
        private MetroFramework.Controls.MetroButton metroButtonZmienHaslo;
    }
}