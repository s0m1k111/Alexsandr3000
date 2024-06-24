using System.Windows.Forms;

namespace Alexsandr3000
{
    public partial class Form1 : Form
    {
        private List<PictureBox> pikcha;
        private int hohol = 0;
        public Form1()
        {
            InitializeComponent();
            pikcha = new()
            { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5};
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox6.Location = pikcha[new Random().Next(pikcha.Count)].Location;
            pictureBox6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hohol = 0;
            label1.Text = "Î×ÊÎ: " + hohol.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            hohol++;
            label1.Text = "Î×ÊÎ: " + hohol.ToString();
            pictureBox6.Visible = false;
        }
    }
}
