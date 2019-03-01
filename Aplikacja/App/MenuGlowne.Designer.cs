namespace MainApp
{
    partial class MenuGlowne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGlowne));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonStatystyka = new MetroFramework.Controls.MetroButton();
            this.metroButtonFaktury = new MetroFramework.Controls.MetroButton();
            this.metroButtonPersonel = new MetroFramework.Controls.MetroButton();
            this.metroButtonMagazyn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 88);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 322);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Alan Buda";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroButtonStatystyka
            // 
            this.metroButtonStatystyka.Location = new System.Drawing.Point(46, 260);
            this.metroButtonStatystyka.Name = "metroButtonStatystyka";
            this.metroButtonStatystyka.Size = new System.Drawing.Size(192, 29);
            this.metroButtonStatystyka.TabIndex = 8;
            this.metroButtonStatystyka.Text = "STATYSTYKA";
            this.metroButtonStatystyka.Click += new System.EventHandler(this.metroButtonStatystyka_Click);
            // 
            // metroButtonFaktury
            // 
            this.metroButtonFaktury.Location = new System.Drawing.Point(46, 225);
            this.metroButtonFaktury.Name = "metroButtonFaktury";
            this.metroButtonFaktury.Size = new System.Drawing.Size(192, 29);
            this.metroButtonFaktury.TabIndex = 9;
            this.metroButtonFaktury.Text = "FAKTURY";
            this.metroButtonFaktury.Click += new System.EventHandler(this.metroButtonFaktury_Click);
            // 
            // metroButtonPersonel
            // 
            this.metroButtonPersonel.Location = new System.Drawing.Point(46, 190);
            this.metroButtonPersonel.Name = "metroButtonPersonel";
            this.metroButtonPersonel.Size = new System.Drawing.Size(192, 29);
            this.metroButtonPersonel.TabIndex = 10;
            this.metroButtonPersonel.Text = "PERSONEL";
            this.metroButtonPersonel.Click += new System.EventHandler(this.metroButtonPersonel_Click);
            // 
            // metroButtonMagazyn
            // 
            this.metroButtonMagazyn.Location = new System.Drawing.Point(46, 155);
            this.metroButtonMagazyn.Name = "metroButtonMagazyn";
            this.metroButtonMagazyn.Size = new System.Drawing.Size(192, 29);
            this.metroButtonMagazyn.TabIndex = 11;
            this.metroButtonMagazyn.Text = "MAGAZYN";
            this.metroButtonMagazyn.Click += new System.EventHandler(this.metroButtonMagazyn_Click);
            // 
            // MenuGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 350);
            this.Controls.Add(this.metroButtonMagazyn);
            this.Controls.Add(this.metroButtonPersonel);
            this.Controls.Add(this.metroButtonFaktury);
            this.Controls.Add(this.metroButtonStatystyka);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuGlowne";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonStatystyka;
        private MetroFramework.Controls.MetroButton metroButtonFaktury;
        private MetroFramework.Controls.MetroButton metroButtonPersonel;
        private MetroFramework.Controls.MetroButton metroButtonMagazyn;
    }
}