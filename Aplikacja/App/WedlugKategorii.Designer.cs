namespace MainApp
{
    partial class WedlugKategorii
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
            this.listBoxKategorieProduktow = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonWybierz = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBoxKategorieProduktow
            // 
            this.listBoxKategorieProduktow.FormattingEnabled = true;
            this.listBoxKategorieProduktow.Location = new System.Drawing.Point(33, 57);
            this.listBoxKategorieProduktow.Name = "listBoxKategorieProduktow";
            this.listBoxKategorieProduktow.Size = new System.Drawing.Size(120, 147);
            this.listBoxKategorieProduktow.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(33, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Wybierz kategorię";
            // 
            // metroButtonWybierz
            // 
            this.metroButtonWybierz.Location = new System.Drawing.Point(33, 226);
            this.metroButtonWybierz.Name = "metroButtonWybierz";
            this.metroButtonWybierz.Size = new System.Drawing.Size(120, 23);
            this.metroButtonWybierz.TabIndex = 5;
            this.metroButtonWybierz.Text = "WYBIERZ";
            this.metroButtonWybierz.Click += new System.EventHandler(this.metroButtonWybierz_Click);
            // 
            // WedlugKategorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 261);
            this.Controls.Add(this.metroButtonWybierz);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBoxKategorieProduktow);
            this.Name = "WedlugKategorii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxKategorieProduktow;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonWybierz;
    }
}