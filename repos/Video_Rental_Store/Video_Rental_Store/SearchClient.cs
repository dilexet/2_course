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
    public partial class SearchClient : Form
    {
        public SearchClient()
        {
            InitializeComponent();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Client main = this.Owner as Client;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridViewClient.RowCount; i++)
                {
                    main.dataGridViewClient.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridViewClient.ColumnCount; j++)
                        if (main.dataGridViewClient.Rows[i].Cells[j].Value != null)
                            if (main.dataGridViewClient.Rows[i].Cells[j].Value.ToString().Contains(SearchBox.Text))
                            {
                                main.dataGridViewClient.Rows[i].Selected = true;
                                break;
                            }
                }
            }
           
        }
    }
}
