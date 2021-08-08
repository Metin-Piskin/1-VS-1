using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_VS_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int p1can=100 , p1damage, p2can=100 , p2damage;

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random r2 = new Random();
            p2damage = r2.Next(1, 10);
            label4.Text = p2damage.ToString();
            label5.Text = (p1can - p2damage).ToString();
            button1.Enabled = true;
            button2.Enabled = false;
            label5.BackColor = Color.Red;
            p1can = p1can - p2damage;
            if (p1can <= 0)
            {
                MessageBox.Show("Player 2 Kazandı", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            p1can = 100;
            p2can = 100;
            label5.Text = p1can.ToString();
            label7.Text = p2can.ToString();
            label3.Text = "0";
            label4.Text = "0";
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            label5.BackColor = Color.Green;
            label7.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Random r1 = new Random();
            p1damage = r1.Next(1, 10);
            label3.Text = p1damage.ToString();
            label7.Text = (p2can-p1damage).ToString();
            button1.Enabled = false;
            button2.Enabled = true;
            label7.BackColor = Color.Red;
            p2can = p2can - p1damage;
            if (p2can <= 0)
            {
                MessageBox.Show("Player 1 Kazandı", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button4.Enabled = true;
            label7.Text = "100";
            label5.Text = "100";
            label5.BackColor = Color.Green;
            label7.BackColor = Color.Green;
        }
    }
}
