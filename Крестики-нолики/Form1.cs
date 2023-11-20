using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_нолики
{
    public partial class Form1 : Form
    {
        private int player;
        private Button[,] buttons = new Button[3, 3];
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            if (random.Next(1, 10) <= 5)
                player = 0;
            else
                player = 1;
            label1.Text = $"Текущий ход: игрок {player + 1}";
            buttons[0, 0] = button1;
            buttons[0, 1] = button2;
            buttons[0, 2] = button3;
            buttons[1, 0] = button4;
            buttons[1, 1] = button5;
            buttons[1, 2] = button6;
            buttons[2, 0] = button7;
            buttons[2, 1] = button8;
            buttons[2, 2] = button9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sender.GetType().GetProperty("Text").SetValue(sender, (player == 0) ? "0" : "x");
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            player = (player + 1) % 2;
            label1.Text = $"Текущий ход: игрок {player + 1}";
            checkWin();
        }
        private void checkWin()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show($"Победили игрок {(player + 1) % 2 + 1}");
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show($"Победили игрок {(player + 1) % 2 + 1}");
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show($"Победили игрок {(player + 1) % 2 + 1}");
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                    MessageBox.Show($"Победили игрок {(player + 1) % 2 + 1}");
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                    MessageBox.Show($"Победили игрок {(player + 1) % 2 + 1}");
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                    MessageBox.Show($"Победили игрок {(player + 1) % 2 + 1}");
            }
            if (button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show($"Победили игрок {(player + 1) % 2 + 1}");
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show($"Победили игрок {(player + 1) % 2 + 1}");
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show($"Победили игрок {(player + 1) % 2 + 1}");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;
                }
            }
        }
    }
}
