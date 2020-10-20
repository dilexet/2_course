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
    public partial class DVD : Form
    {
        /// <summary>
        /// true если менеджер
        /// </summary>
        private bool isManagerOrClerk { get; set; }

        public DVD(bool isManagerOrClerk)
        {
            InitializeComponent();
            this.isManagerOrClerk = isManagerOrClerk;
        }

        private void DVD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gamesDataSet.DVDgames". При необходимости она может быть перемещена или удалена.
            this.dVDgamesTableAdapter.Fill(this.gamesDataSet.DVDgames);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moviesDataSet.DVDmovie". При необходимости она может быть перемещена или удалена.
            this.dVDmovieTableAdapter.Fill(this.moviesDataSet.DVDmovie);

        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            if (isManagerOrClerk)
            {
                dVDmovieTableAdapter.Update(moviesDataSet);
                dVDgamesTableAdapter.Update(gamesDataSet);
            }
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!isManagerOrClerk)
            {
                MessageBox.Show("У вас нет прав для изменения данных.", "Предупрждение");
                return;
            }
            dVDmovieTableAdapter.Update(moviesDataSet);
            dVDgamesTableAdapter.Update(gamesDataSet);
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            if (!isManagerOrClerk)
            {
                MessageBox.Show("У вас нет прав для изменения данных.", "Предупрждение");
                return;
            }
            AddMovies addmovies = new AddMovies();
            addmovies.Owner = this;
            addmovies.Show();
        }

        private void SearchMovieButton_Click(object sender, EventArgs e)
        {
            SearchMovies searchmovies = new SearchMovies();
            searchmovies.Owner = this;
            searchmovies.Show();
        }

        private void AddGameButton_Click(object sender, EventArgs e)
        {
            if (!isManagerOrClerk)
            {
                MessageBox.Show("У вас нет прав для изменения данных.", "Предупрждение");
                return;
            }
            AddGames addgames = new AddGames();
            addgames.Owner = this;
            addgames.Show();
        }

        private void SearchGameButton_Click(object sender, EventArgs e)
        {
            SearchGames searchgames = new SearchGames();
            searchgames.Owner = this;
            searchgames.Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
    }
}
