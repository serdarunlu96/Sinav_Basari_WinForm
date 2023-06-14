namespace Sinav_Basari_WinForm
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblAdSoyad = new Label();
            lblOrtalama = new Label();
            lblBasariDurumu = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Adi Soyadi: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 65);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Ortalama:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 101);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 2;
            label3.Text = "Basari Durumu:";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(133, 33);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(0, 15);
            lblAdSoyad.TabIndex = 3;
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(133, 65);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(0, 15);
            lblOrtalama.TabIndex = 4;
            // 
            // lblBasariDurumu
            // 
            lblBasariDurumu.AutoSize = true;
            lblBasariDurumu.Location = new Point(133, 101);
            lblBasariDurumu.Name = "lblBasariDurumu";
            lblBasariDurumu.Size = new Size(0, 15);
            lblBasariDurumu.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 149);
            Controls.Add(lblBasariDurumu);
            Controls.Add(lblOrtalama);
            Controls.Add(lblAdSoyad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "SONUC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public Label lblAdSoyad;
        public Label lblOrtalama;
        public Label lblBasariDurumu;
    }
}