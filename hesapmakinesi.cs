namespace Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bTopla_Click(object sender, EventArgs e)
        {
            double sonuc;
            tbIslem.Text = tbSayi1.Text + " + " + tbSayi2.Text;
            sonuc = Convert.ToDouble(tbSayi1.Text) + Convert.ToDouble(tbSayi2.Text);
            tbSonuc.Text = sonuc.ToString();
        }

        private void bCikar_Click(object sender, EventArgs e)
        {
            double sonuc;
            tbIslem.Text = tbSayi1.Text + " - " + tbSayi2.Text;
            sonuc = Convert.ToDouble(tbSayi1.Text) - Convert.ToDouble(tbSayi2.Text);
            tbSonuc.Text = sonuc.ToString();
        }

        private void bCarp_Click(object sender, EventArgs e)
        {
            double sonuc;
            tbIslem.Text = tbSayi1.Text + " x " + tbSayi2.Text;
            sonuc = Convert.ToDouble(tbSayi1.Text) * Convert.ToDouble(tbSayi2.Text);
            tbSonuc.Text = sonuc.ToString();
        }

        private void bBol_Click(object sender, EventArgs e)
        {
            double sonuc;
            tbIslem.Text = tbSayi1.Text + " / " + tbSayi2.Text;

            if (Convert.ToDouble(tbSayi2.Text) == 0)
            {
                tbSonuc.Text = "Bölme Hatasý (0'a bölme)";
            }
            else
            {
                sonuc = Convert.ToDouble(tbSayi1.Text) / Convert.ToDouble(tbSayi2.Text);
                tbSonuc.Text = sonuc.ToString();
            }
        }

        private void bKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
