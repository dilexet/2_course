using MySql.Data.MySqlClient;
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
    public partial class Cards : Form
    {
        public Cards()
        {
            InitializeComponent();
            XZ_Name();
        }

        private void XZ_Name()
        {
            NumberCard.Text = "Введите номер карты";
            NumberCard.ForeColor = Color.Gray;
        }
        /// <summary>
        /// Проверка карты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (NumberCard.Text == "Введите номер карты")
            {
                MessageBox.Show("Введите номер карты!");
                return;
            }
            NewCard[] cards = null;
            AddNewCards.Output(ref cards);
            long.TryParse(NumberCard.Text, out long card_number);
            if (card_number == 0)
            {
                MessageBox.Show("Введён некорректный номер");
                return;
            }
                
            String cardType = CardType.GetCardType(card_number, cards);
            if (Invalid.CardCheck(card_number))
                MessageBox.Show("Тип карточки -- " + cardType + "\nКарточка прошла идентификацию.");
            else
                MessageBox.Show("Тип карточки -- " + cardType + "\nКарточка не прошла идентификацию.");
            XZ_Name();
        }

        /// <summary>
        /// Переход между окнами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCards addcards = new AddCards();
            addcards.Show();
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

        private void PanelValid_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void PanelValid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void NumberCard_Enter(object sender, EventArgs e)
        {
            if (NumberCard.Text == "Введите номер карты")
            {
                NumberCard.Text = "";
                NumberCard.ForeColor = Color.Black;
            }
        }

        private void NumberCard_Leave(object sender, EventArgs e)
        {
            if (NumberCard.Text == "")
            {
                NumberCard.Text = "Введите номер карты";
                NumberCard.ForeColor = Color.Gray;
            }
        }
    }
}
