using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_Forms_
{
    public partial class Form1 : Form
    {
        public string operation;
        public string num;
        public bool is_input;
        public Form1()
        {
            is_input = false;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (is_input)
            {
                textBox1.Text = "0";
                is_input = false;
            }
            Button button = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = button.Text;
            else
                textBox1.Text += button.Text;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            num = textBox1.Text;
            is_input = true;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            double n1, n2, res = 0;
            n1 = double.Parse(num);
            n2 = double.Parse(textBox1.Text);
            switch (operation)
            {
                case "+":
                    res = n1 + n2;
                    break;
                case "-":
                    res = n1 - n2;
                    break;
                case "*":
                    res = n1 * n2;
                    break;
                case "/":
                    res = n1 / n2;
                    break;
                case "%":
                    res = n1 / n2 * 100; ;
                    break;
            }
            is_input = true;
            operation = "=";
            textBox1.Text = res.ToString();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            double res = -num;
            textBox1.Text = res.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            double res = Math.Sqrt(num);
            textBox1.Text = res.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            double res = Math.Pow(num, 2);
            textBox1.Text = res.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double num = double.Parse(textBox1.Text);
            double res = 1 / num;
            textBox1.Text = res.ToString();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(','))
                textBox1.Text += ",";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }
    }
}
