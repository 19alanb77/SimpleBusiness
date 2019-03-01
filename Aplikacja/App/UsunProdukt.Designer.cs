namespace MainApp
{
    partial class UsunProdukt
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
            this.metroTextBoxIlosc = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonUsun = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBoxProdukt
            // 
            this.listBoxProdukt.FormattingEnabled = true;
            this.listBoxProdukt.Location = new System.Drawing.Point(74, 48);
            this.listBoxProdukt.Name = "listBoxProdukt";
            this.listBoxProdukt.Size = new System.Drawing.Size(120, 121);
            this.listBoxProdukt.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(105, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Produkt";
            // 
            // metroTextBoxIlosc
            // 
            this.metroTextBoxIlosc.Location = new System.Drawing.Point(74, 197);
            this.metroTextBoxIlosc.Name = "metroTextBoxIlosc";
            this.metroTextBoxIlosc.Size = new System.Drawing.Size(120, 23);
            this.metroTextBoxIlosc.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(116, 175);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Ilość";
            // 
            // metroButtonUsun
            // 
            this.metroButtonUsun.Location = new System.Drawing.Point(74, 238);
            this.metroButtonUsun.Name = "metroButtonUsun";
            this.metroButtonUsun.Size = new System.Drawing.Size(120, 32);
            this.metroButtonUsun.TabIndex = 8;
            this.metroButtonUsun.Text = "USUŃ";
            this.metroButtonUsun.Click += new System.EventHandler(this.metroButtonUsun_Click);
            // 
            // UsunProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.metroButtonUsun);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxIlosc);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBoxProdukt);
            this.Name = "UsunProdukt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProdukt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxIlosc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButtonUsun;
    }
}