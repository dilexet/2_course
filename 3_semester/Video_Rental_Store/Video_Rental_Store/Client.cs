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
    public partial class Client : Form
    {
        /// <summary>
        /// true если менеджер
        /// </summary>
        private bool isManagerOrClerk { get; set; }
        public Client(bool isManagerOrClerk)
        {
            InitializeComponent();
            this.isManagerOrClerk = isManagerOrClerk;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clientDataSet.customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.clientDataSet.customer);
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            customerTableAdapter.Update(clientDataSet);
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            customerTableAdapter.Update(clientDataSet);
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (isManagerOrClerk)
            {
                DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Вы не имеете прав для удаления записи!", "Предупреждение");
                e.Cancel = true;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddClient addclient = new AddClient();
            addclient.Owner = this;
            addclient.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchClient searchClient = new SearchClient();
            searchClient.Owner = this;
            searchClient.Show();
        }
    }
}
