using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_taking_program
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title");
            table.Columns.Add("Message");
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 1)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                textBox1.Text = table.Rows[index].ItemArray[0].ToString();
                textBox2.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }
    }
}
