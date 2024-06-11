namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        FormMine Form_IM;
        Mine Iron_Mine;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            Iron_Mine = new Mine();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_IM = new();
            Form_IM.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Iron_Mine.Tick();
            if(Form_IM != null) { 
            Form_IM.Show(Iron_Mine.Ore, Iron_Mine.Worker);
            }
        }
    }
}
