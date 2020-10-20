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
    public partial class SearchGames : Form
    {
        public SearchGames()
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
            DVD main = this.Owner as DVD;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridViewGames.RowCount; i++)
                {
                    main.dataGridViewGames.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridViewGames.ColumnCount; j++)
                        if (main.dataGridViewGames.Rows[i].Cells[j].Value != null)
                            if (main.dataGridViewGames.Rows[i].Cells[j].Value.ToString().Contains(SearchBox.Text))
                            {
                                main.dataGridViewGames.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        
    }
}
