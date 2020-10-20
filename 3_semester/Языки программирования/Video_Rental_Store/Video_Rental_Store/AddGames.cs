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
    public partial class AddGames : Form
    {
        public AddGames()
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

        private bool IsCorrectData()
        {
            if (!uint.TryParse(CostBox.Text, out uint number))
                return false;
            if (!double.TryParse(NumberBox.Text, out double cost))
                return false;
            if (double.Parse(NumberBox.Text) <= 0)
                return false;
            return true;
        }

        private bool SearchMatches(DVD main)
        {
            for (int i = 0; i < main.dataGridViewGames.RowCount; i++)
            {
                if (main.dataGridViewGames.Rows[i].Cells[1].Value != null)
                    if (main.dataGridViewGames.Rows[i].Cells[1].Value.ToString().Contains(NameBox.Text))
                    {
                        uint.TryParse(main.dataGridViewGames.Rows[i].Cells[2].Value.ToString(), out uint number);
                        main.dataGridViewGames.Rows[i].Cells[2].Value = number + 1;
                        NameBox.Text = "";
                        NumberBox.Text = "";
                        CostBox.Text = "";
                        return false;
                    }
            }
            return true;
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!IsCorrectData())
            {
                MessageBox.Show("Данные введены некорректно!", "Ошибка");
                return;
            }
            DVD main = this.Owner as DVD;
            if (main != null && SearchMatches(main)) 
            {
                DataRow nRow = main.gamesDataSet.Tables[0].NewRow();
                int rc = main.dataGridViewGames.RowCount;
                nRow[0] = rc;
                nRow[1] = NameBox.Text;
                nRow[2] = NumberBox.Text;
                nRow[3] = CostBox.Text;
                main.gamesDataSet.Tables[0].Rows.Add(nRow);
                main.dVDgamesTableAdapter.Update(main.gamesDataSet.DVDgames);
                main.gamesDataSet.Tables[0].AcceptChanges();
                main.dataGridViewGames.Refresh();
                NameBox.Text = "";
                NumberBox.Text = "";
                CostBox.Text = "";
            }
        }

        
    }
}
