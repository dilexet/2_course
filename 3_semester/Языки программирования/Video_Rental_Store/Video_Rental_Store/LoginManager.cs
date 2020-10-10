using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_Store
{
    public partial class LoginManager : Form
    {
        public LoginManager()
        {
            InitializeComponent();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ComeBackLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu videoRentalStore = new StartMenu();
            videoRentalStore.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginBox.Text;
            String passUser = PasswordBox.Text;

            DataBaseManager db = new DataBaseManager();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `manager` WHERE `login` = @uL AND `password` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Client client = new Client();
                client.Show();
            }
            else
                MessageBox.Show("Ошибка авторизации.");
        }

    }
}
