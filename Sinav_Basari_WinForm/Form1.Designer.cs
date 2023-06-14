namespace Sinav_Basari_WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            txtSinav1 = new TextBox();
            txtSinav2 = new TextBox();
            label3 = new Label();
            txtSinav3 = new TextBox();
            label4 = new Label();
            btnHesapla = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Adi Soyadi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 54);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Sinav Notu 1:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(108, 24);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(244, 23);
            txtAdSoyad.TabIndex = 5;
            // 
            // txtSinav1
            // 
            txtSinav1.Location = new Point(108, 54);
            txtSinav1.Name = "txtSinav1";
            txtSinav1.Size = new Size(244, 23);
            txtSinav1.TabIndex = 6;
            // 
            // txtSinav2
            // 
            txtSinav2.Location = new Point(108, 83);
            txtSinav2.Name = "txtSinav2";
            txtSinav2.Size = new Size(244, 23);
            txtSinav2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 86);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 7;
            label3.Text = "Sinav Notu 2:";
            // 
            // txtSinav3
            // 
            txtSinav3.Location = new Point(108, 112);
            txtSinav3.Name = "txtSinav3";
            txtSinav3.Size = new Size(244, 23);
            txtSinav3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 115);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 9;
            label4.Text = "Sinav Notu 3:";
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(24, 154);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(328, 36);
            btnHesapla.TabIndex = 11;
            btnHesapla.Text = "HESAPLA";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 217);
            Controls.Add(btnHesapla);
            Controls.Add(txtSinav3);
            Controls.Add(label4);
            Controls.Add(txtSinav2);
            Controls.Add(label3);
            Controls.Add(txtSinav1);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SINAV HESAPLAMA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAdSoyad;
        private TextBox txtSinav1;
        private TextBox txtSinav2;
        private Label label3;
        private TextBox txtSinav3;
        private Label label4;
        private Button btnHesapla;
    }
}