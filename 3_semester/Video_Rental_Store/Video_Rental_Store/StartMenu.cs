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
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginManagerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginManager loginManager = new LoginManager();
            loginManager.Show();
        }

        private void LoginClerkButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginClerks loginClerks = new LoginClerks();
            loginClerks.Show();
        }

    }
}
