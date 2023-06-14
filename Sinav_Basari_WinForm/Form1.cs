namespace Sinav_Basari_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double ortalama;
            Form2 acilacakForm = new Form2();
            acilacakForm.lblAdSoyad.Text = txtAdSoyad.Text;
            ortalama = (Convert.ToDouble(txtSinav1.Text) + Convert.ToDouble(txtSinav2.Text) + Convert.ToDouble(txtSinav3.Text)) / 3;
            acilacakForm.lblOrtalama.Text=ortalama.ToString();
            if (ortalama < 60)
                acilacakForm.lblBasariDurumu.Text = "BASARISIZ";
            else
                acilacakForm.lblBasariDurumu.Text = "BASARILI";
            acilacakForm.Show();
        }
    }
}