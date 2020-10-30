using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankCard
{
    public partial class AddCards : Form
    {
        public AddCards()
        {
            InitializeComponent();
            XZ_Name();
        }
        private void XZ_Name()
        {
            TypeCard.Text = "Введите тип карты";
            TypeCard.ForeColor = Color.Gray;

            DigitCount.Text = "Введите количество цифр";
            DigitCount.ForeColor = Color.Gray;

            Digits.Text = "Введите первые цифры";
            Digits.ForeColor = Color.Gray;
        }
        /// <summary>
        /// Добавление карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (TypeCard.Text == "Введите тип карты")
            {
                MessageBox.Show("Введите тип карты!");
                return;
            }
            if (DigitCount.Text == "Введите количество цифр")
            {
                MessageBox.Show("Введите количество цифр!");
                return;
            }
            if (Digits.Text == "Введите первые цифры")
            {
                MessageBox.Show("Введите первые цифры!");
                return;
            }
            string cardType = TypeCard.Text;
            uint.TryParse(DigitCount.Text, out uint digitsCount);
            if (digitsCount == 0)
            {
                MessageBox.Show("Введены некорректные данные");
                return;
            }
            int.TryParse(Digits.Text, out int digit);
            if (digit <= 0) 
            {
                MessageBox.Show("Введены некорректные данные");
                return;
            }
            string digits = Convert.ToString(digit);
            AddNewCards.CreationNewCard(cardType, digits, digitsCount);
            MessageBox.Show("Карта добавлена");
            XZ_Name();
        }

        /// <summary>
        /// Переход между окнами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelInv_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cards cards = new Cards();
            cards.Show();
        }

        /// <summary>
        /// Закрывает окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Red;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.White;
        }

        Point lastPoint;

        private void PanelRegistr_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PanelRegistr_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TypeCard_Enter(object sender, EventArgs e)
        {
            if (TypeCard.Text == "Введите тип карты")
            {
                TypeCard.Text = "";
                TypeCard.ForeColor = Color.Black;
            }
        }

        private void TypeCard_Leave(object sender, EventArgs e)
        {
            if (TypeCard.Text == "")
            {
                TypeCard.Text = "Введите тип карты";
                TypeCard.ForeColor = Color.Gray;
            }
        }

        private void DigitCount_Enter(object sender, EventArgs e)
        {
            if (DigitCount.Text == "Введите количество цифр")
            {
                DigitCount.Text = "";
                DigitCount.ForeColor = Color.Black;
            }
        }

        private void DigitCount_Leave(object sender, EventArgs e)
        {
            if (DigitCount.Text == "")
            {
                DigitCount.Text = "Введите количество цифр";
                DigitCount.ForeColor = Color.Gray;
            }
        }

        private void Digits_Enter(object sender, EventArgs e)
        {
            if (Digits.Text == "Введите первые цифры")
            {
                Digits.Text = "";
                Digits.ForeColor = Color.Black;
            }
        }

        private void Digits_Leave(object sender, EventArgs e)
        {
            if (Digits.Text == "")
            {
                Digits.Text = "Введите первые цифры";
                Digits.ForeColor = Color.Gray;
            }
        }
    }
}
