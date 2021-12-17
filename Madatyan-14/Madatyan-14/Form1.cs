using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rabota14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(x * 100 + 1000);
            }

            if (radioButton2.Checked)
            {
                int x = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(x * 100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = null;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
