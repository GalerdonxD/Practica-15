namespace Practica_15
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

        private void button1_Click(object sender, EventArgs e)
        {
            double sue, nsue;

            sue = double.Parse(sueldo.Text);

            if (sue < 400000.00)
                nsue = sue * 1.15;

            else
                nsue = sue * 1.08;
            Nsueldo.Text = nsue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sueldo.Text = " ";
            Nsueldo.Text = " ";
        }
    }
}