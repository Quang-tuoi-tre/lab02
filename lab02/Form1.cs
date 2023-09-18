using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtBox1.Text);
            float number2 = float.Parse(txtBox2.Text);
            float result = number1 + number2;
            txtAnswer.Text = result.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtBox1.Text);
            float number2 = float.Parse(txtBox2.Text);
            float result = number1 - number2;
            txtAnswer.Text = result.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtBox1.Text);
            float number2 = float.Parse(txtBox2.Text);
            float result = number1 * number2;
            txtAnswer.Text = result.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            float number1 = float.Parse(txtBox1.Text);
            float number2 = float.Parse(txtBox2.Text);
            float result = number1 / number2;
            txtAnswer.Text = result.ToString();
        }
    }
}
