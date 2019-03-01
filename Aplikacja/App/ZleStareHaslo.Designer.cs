namespace MainApp
{
    partial class ZleStareHaslo
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
            this.labelZleStareHaslo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelZleStareHaslo
            // 
            this.labelZleStareHaslo.AutoSize = true;
            this.labelZleStareHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZleStareHaslo.Location = new System.Drawing.Point(13, 42);
            this.labelZleStareHaslo.Name = "labelZleStareHaslo";
            this.labelZleStareHaslo.Size = new System.Drawing.Size(259, 20);
            this.labelZleStareHaslo.TabIndex = 0;
            this.labelZleStareHaslo.Text = "Wprowadzono nieprawidłowe dane!";
            // 
            // ZleStareHaslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.labelZleStareHaslo);
            this.Name = "ZleStareHaslo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZleStareHaslo;
    }
}