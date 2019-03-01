namespace MainApp
{
    partial class ZleLogowanie
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
            this.labelZleLogowanie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelZleLogowanie
            // 
            this.labelZleLogowanie.AutoSize = true;
            this.labelZleLogowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZleLogowanie.Location = new System.Drawing.Point(27, 40);
            this.labelZleLogowanie.Name = "labelZleLogowanie";
            this.labelZleLogowanie.Size = new System.Drawing.Size(230, 20);
            this.labelZleLogowanie.TabIndex = 0;
            this.labelZleLogowanie.Text = "Nieprawidłowe dane logowania!";
            // 
            // ZleLogowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.labelZleLogowanie);
            this.Name = "ZleLogowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelZleLogowanie;
    }
}