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
    public partial class SearchMovies : Form
    {
        public SearchMovies()
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
                for (int i = 0; i < main.dataGridViewMovies.RowCount; i++)
                {
                    main.dataGridViewMovies.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridViewMovies.ColumnCount; j++)
                        if (main.dataGridViewMovies.Rows[i].Cells[j].Value != null)
                            if (main.dataGridViewMovies.Rows[i].Cells[j].Value.ToString().Contains(SearchBox.Text))
                            {
                                main.dataGridViewMovies.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
