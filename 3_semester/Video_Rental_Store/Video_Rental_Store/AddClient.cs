using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_Store
{
    public partial class AddClient : Form
    {
        public AddClient()
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
            const string regPhone = @"^(\+375|80)(29|25|44|33)(\d{3})(\d{2})(\d{2})$";
            const string reg = "^[A-Z][a-z]+$";
            if (!Regex.IsMatch(SurnameBox.Text, reg))
                return false;
            if (!Regex.IsMatch(NameBox.Text, reg))
                return false;
            if (!Regex.IsMatch(StreetBox.Text, reg))
                return false;
            if (!Regex.IsMatch(PhoneBox.Text, regPhone))
                return false;
            if (!int.TryParse(HouseBox.Text, out int house))
                return false;
            if (!int.TryParse(ApartamentBox.Text, out int apartament))
                return false;
            return true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!IsCorrectData())
            {
                MessageBox.Show("Данные введены некорректно!", "Ошибка");
                return;
            }
            Client main = this.Owner as Client;
            if (main != null)
            {
                Random random = new Random();
                DataRow nRow = main.clientDataSet.Tables[0].NewRow();
                int rc = main.dataGridViewClient.RowCount;
                nRow[0] = rc;
                nRow[1] = SurnameBox.Text;
                nRow[2] = NameBox.Text;
                nRow[3] = PhoneBox.Text;
                nRow[4] = StreetBox.Text;
                nRow[5] = HouseBox.Text;
                nRow[6] = ApartamentBox.Text;
                nRow[7] = Convert.ToString(random.Next(1000, 9999)) + "-" + Convert.ToString(random.Next(1000, 9999));
                main.clientDataSet.Tables[0].Rows.Add(nRow);
                main.customerTableAdapter.Update(main.clientDataSet.customer);
                main.clientDataSet.Tables[0].AcceptChanges();
                main.dataGridViewClient.Refresh();
                SurnameBox.Text = "";
                NameBox.Text = "";
                ApartamentBox.Text = "";
                PhoneBox.Text = "";
                StreetBox.Text = "";
                HouseBox.Text = "";
            }
        }

       
    }
}
