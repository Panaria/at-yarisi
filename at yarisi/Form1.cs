using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Left - pictureBox2.Width > pictureBox2.Left)
            {
                pictureBox2.Left += rnd.Next(1, 20);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Beyaz At Kazandı");
            }
            if (button1.Left - pictureBox3.Width > pictureBox3.Left)
            {
                pictureBox3.Left += rnd.Next(1, 20);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Kahverengi At Kazandı");
            }
            if (button1.Left - pictureBox4.Width > pictureBox4.Left)
            {
                pictureBox4.Left += rnd.Next(1, 20);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Turuncu At Kazandı");
            }
        }
    }
}
