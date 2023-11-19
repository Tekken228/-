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
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            if (random.Next(1, 10) <= 5)
                player = 0;
            else
                player = 1;
            label1.Text = $"Текущий ход: игрок {player + 1}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sender.GetType().GetProperty("Text").SetValue(sender, (player == 0) ? "0" : "x");
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            player = (player + 1) % 2;
            label1.Text = $"Текущий ход: игрок {player + 2}";
        }
    }
}
