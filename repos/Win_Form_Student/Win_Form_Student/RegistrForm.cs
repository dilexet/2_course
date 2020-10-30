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

namespace Win_Form_Student
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
            UserName.Text = "Введите имя";
            UserName.ForeColor = Color.Gray;
            UserSurName.Text = "Введите фамилию";
            UserSurName.ForeColor = Color.Gray;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        private void LabelRegistr_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LabelRegistr_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;

        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            if (UserName.Text == "Введите имя")
            {
                UserName.Text = "";
                UserName.ForeColor = Color.Black;
            }
                
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {
                UserName.Text = "Введите имя";
                UserName.ForeColor = Color.Gray;
            }
        }

        private void UserSurName_Enter(object sender, EventArgs e)
        {
            if (UserSurName.Text == "Введите фамилию")
            {
                UserSurName.Text = "";
                UserSurName.ForeColor = Color.Black;
            }
        }

        private void UserSurName_Leave(object sender, EventArgs e)
        {
            if (UserSurName.Text == "")
            {
                UserSurName.Text = "Введите Фамилию";
                UserSurName.ForeColor = Color.Gray;
            }
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя!");
                return;
            }
            //...

            if (isUserLogin())
                return;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `Name`, `Surname`) VALUES (@Login, @Password, @Name, @Surname)", db.getConnection());

            command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = Login.Text;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = Password.Text;
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = UserName.Text;
            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = UserSurName.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");
            db.closeConnection();



        }

        public Boolean isUserLogin()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Login.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть");
                return true;
            }
            else
                return false;
        }

        private void RegLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm logForm = new LoginForm();
            logForm.Show();
        }
    }
}
