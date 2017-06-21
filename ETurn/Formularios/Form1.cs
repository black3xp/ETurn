using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ETurn
{
    public partial class ETurn : Form
    {
        public ETurn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ETurn_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.10;
            if(this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            //pictureBox1.Width = 122;
            //pictureBox1.Height = 116;

            pictureBox1.BackColor = Color.Yellow;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox1.Width = 142;
            //pictureBox1.Height = 136;

            pictureBox1.BackColor = Color.White;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            //pictureBox2.Width = 122;
            //pictureBox2.Height = 116;

            pictureBox2.BackColor = Color.Yellow;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox2.Width = 142;
            //pictureBox2.Height = 136;

            pictureBox2.BackColor = Color.White;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            //pictureBox3.Width = 122;
            //pictureBox3.Height = 116;

            pictureBox3.BackColor = Color.Yellow;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox3.Width = 142;
            //pictureBox3.Height = 136;

            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            entregaTicket ticket = new entregaTicket();
            ticket.Show();
        }

    }
}
