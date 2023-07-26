using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // operacja dodawania
            float f1 = float.Parse(textBox1.Text);
            float f2 = float.Parse(textBox2.Text);
            float w = f1 + f2;
            label4.Text = f1.ToString() + "+" + f2 + "=" + w;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {   // operacja odejmowania
            float f1 = float.Parse(textBox1.Text);
            float f2 = float.Parse(textBox2.Text);
            float w = f1 - f2;
            label4.Text = f1.ToString() + "-" + f2 + "=" + w;
        }

        private void button3_Click(object sender, EventArgs e)
        {   //operacja mnożenia
            float f1 = float.Parse(textBox1.Text);
            float f2 = float.Parse(textBox2.Text);
            float w = f1 * f2;
            label4.Text = f1.ToString() + "*" + f2 + "=" + w;
        }

        private void button2_Click(object sender, EventArgs e)
        {   //operacja dzielenia
            float f1 = float.Parse(textBox1.Text);
            float f2 = float.Parse(textBox2.Text);
            float w = f1 / f2;
            label4.Text = f1.ToString() + "/" + f2 + "=" + w;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
