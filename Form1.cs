namespace örnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Width = 1000;
            Height = 700;

        }

        private void bKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bKapat_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            bKapat.Left = r.Next(0, this.Width - bKapat.Width);
            bKapat.Top = r.Next(0, this.Height - bKapat.Height);
        }
    }
}
