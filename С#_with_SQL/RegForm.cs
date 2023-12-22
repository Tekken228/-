using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace С__with_SQL
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 60);
            this.name.AutoSize = false;
            this.name.Size = new Size(this.passField.Size.Width, 60);
            this.name.Text = "Введите имя";
            name.ForeColor = Color.Gray;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point point;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Введите имя")
            {
                name.Text = "";
                name.ForeColor = Color.Black;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Введите имя";
                name.ForeColor = Color.Gray;
            }
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            if (name.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (sirname.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (loginField.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (isUserExists())
            {
                return;
            }
            DB dB = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `name`, `surname`) VALUES (@login, @pass, @name, @surname)", dB.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = sirname.Text;
            dB.openConnection();
            if (command.ExecuteNonQuery() == 1) // выполняет команду
            {
                MessageBox.Show("Пользователь добавлен");
            }
            else
            {
                MessageBox.Show("Тильт");
            }
            dB.closeConnection();
        }
        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable dt = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @log", db.getConnection());
            mySqlCommand.Parameters.Add("@log", MySqlDbType.VarChar).Value = loginField.Text;
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(dt);
            if (dt.Rows.Count > 0) 
            {
                MessageBox.Show("Уже есть такой пользователь");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
