namespace CalculatorAPP
{
    partial class FrmHasilPerhitungan
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
            this.Hasil = new System.Windows.Forms.GroupBox();
            this.lvwCalculator = new System.Windows.Forms.ListView();
            this.btnHitung = new System.Windows.Forms.Button();
            this.Hasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hasil
            // 
            this.Hasil.Controls.Add(this.lvwCalculator);
            this.Hasil.Location = new System.Drawing.Point(12, 12);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(334, 288);
            this.Hasil.TabIndex = 0;
            this.Hasil.TabStop = false;
            this.Hasil.Text = "Hasil";
            // 
            // lvwCalculator
            // 
            this.lvwCalculator.HideSelection = false;
            this.lvwCalculator.Location = new System.Drawing.Point(6, 19);
            this.lvwCalculator.Name = "lvwCalculator";
            this.lvwCalculator.Size = new System.Drawing.Size(321, 258);
            this.lvwCalculator.TabIndex = 0;
            this.lvwCalculator.UseCompatibleStateImageBehavior = false;
            this.lvwCalculator.SelectedIndexChanged += new System.EventHandler(this.lvwCalculator_SelectedIndexChanged);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(18, 306);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(321, 27);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // FrmHasilPerhitungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 342);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.Hasil);
            this.Name = "FrmHasilPerhitungan";
            this.Text = "Hasil Perhitungan";
            this.Hasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Hasil;
        private System.Windows.Forms.ListView lvwCalculator;
        private System.Windows.Forms.Button btnHitung;
    }
}

