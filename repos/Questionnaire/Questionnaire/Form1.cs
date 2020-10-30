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
using System.IO;

namespace Questionnaire
{
    public partial class Form1 : Form
    {
        private void FillingDays(int amount_of_days = 31)
        {
            if (DaysBox.Items != null)
                DaysBox.Items.Clear();
            for (int i = 1; i <= amount_of_days; i++)
                DaysBox.Items.Add(i);
        }

        private void FillingMonths()
        {
            String[] Months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            foreach (var Month in Months)
            {
                MonthsBox.Items.Add(Month);
            }
        }
        
        private void FillingYears()
        {
            for (int i = 1950; i <= 2002; i++) 
            {
                YearsBox.Items.Add(i);
            }
        }

        private void FillingOperator()
        {
            OperatorBox.Items.Add("МТС");
            OperatorBox.Items.Add("Лайф");
            OperatorBox.Items.Add("Велком");
        }

        public Form1()
        {
            InitializeComponent();
            FillingMonths();
            FillingYears();
            FillingDays();
            FillingOperator();
            WorkExperienceButton1.Checked = true;
            ManButton.Checked = true;
            ScheduleButton1.Checked = true;
            MinWage.SelectedItem = MinWage.Items[0];
            MaxWage.SelectedItem = MaxWage.Items[0];
            OperatorBox.SelectedItem = OperatorBox.Items[0];
        }

        private void MonthsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] Months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            String Month = MonthsBox.SelectedItem.ToString();
            if (Month == Months[3] || Month == Months[5] || Month == Months[8] || Month == Months[10])
                FillingDays(30);
            if (Month == Months[1])
                FillingDays(29);
        }

        private void YearsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MonthsBox.Text == "")
                return;
            int year = int.Parse(YearsBox.SelectedItem.ToString());
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0) && MonthsBox.SelectedItem.ToString() == "Февраль")
                FillingDays(29);
            else
                FillingDays(28);

        }

        private bool isBirthDayCorrect()
        {
            int year;
            String Month;
            int day;
            if (YearsBox.Text == "" || MonthsBox.Text == "" || DaysBox.Text == "")
                return false;
            String[] Months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            try
            {
                year = int.Parse(YearsBox.Text);
                Month = MonthsBox.Text;
                day = int.Parse(DaysBox.Text);
            }
            catch(Exception e)
            {
                return false;
            }
            bool flag = false;
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0) && Month == "Февраль")
            {
                if (day >= 1 && day <= 29)
                    flag = true;
                else
                    flag = false;
            }
            else if (Month == "Февраль") 
            {
                if (day >= 1 && day <= 28)
                    flag = true;
                else
                    flag = false;
            }
            else if (Month == Months[3] || Month == Months[5] || Month == Months[8] || Month == Months[10])
            {
                if (day >= 1 && day <= 30)
                    flag = true;
                else
                    flag = false;
            }
            else
            {
                if (day >= 1 && day <= 31)
                    flag = true;
                else
                    flag = false;
            }
            return flag;
        }

        private bool isDataCorrect(ref String messages)
        {
            const string regNumberPhoneMTC = @"^(\+375|80)(29|33)(\d{3})(\d{2})(\d{2})$";
            const string regNumberPhoneLife = @"^(\+375|80)(25)(\d{3})(\d{2})(\d{2})$";
            const string regNumberPhoneVelcom = @"^(\+375|80)(44)(\d{3})(\d{2})(\d{2})$";
            const string regEmail = @"^((([\w]+\.[\w]+)+)|([\w]+))@(([\w]+\.)+)([A-Za-z]{1,3})$";
            const string regString = "^[A-ZА-Я][a-zа-я]+$";
            StringBuilder message = new StringBuilder("Введены неккоректные данные:\n");
            bool isCorrect = true;
            // Проверка ФИО
            if (!Regex.IsMatch(SurnameTextBox.Text, regString))
            {
                isCorrect = false;
                message.Append("Фамилия\n");
            }
            if (!Regex.IsMatch(NameTextBox.Text, regString))
            {
                isCorrect = false;
                message.Append("Имя\n");
            }
            if (!Regex.IsMatch(LastnameTextBox.Text, regString))
            {
                isCorrect = false;
                message.Append("Отчество\n");
            }

            // Проверка места проживания
            if (CityBox.Text == "")
            {
                isCorrect = false;
                message.Append("Город\n");
            }
            if (StreetBox.Text == "")
            {
                isCorrect = false;
                message.Append("Улица\n");
            }

            // Проверка E-mail
            if (!Regex.IsMatch(EmailAdressBox.Text, regEmail))
            {
                isCorrect = false;
                message.Append("E-mail\n");
            }

            // Проверка номера телефона
            if (OperatorBox.Text == "")
            {
                isCorrect = false;
                message.Append("Номер телефона\n");
            }

            if (OperatorBox.Text == "МТС")
                if (!Regex.IsMatch(MobilePhone.Text, regNumberPhoneMTC))
                {
                    isCorrect = false;
                    message.Append("Номер телефона\n");
                }
            if (OperatorBox.Text == "Лайф")
                if (!Regex.IsMatch(MobilePhone.Text, regNumberPhoneLife))
                {
                    isCorrect = false;
                    message.Append("Номер телефона\n");
                }
            if (OperatorBox.Text == "Велком")
                if (!Regex.IsMatch(MobilePhone.Text, regNumberPhoneVelcom))
                {
                    isCorrect = false;
                    message.Append("Номер телефона\n");
                }

            // Проверка даты рождения
            if (!isBirthDayCorrect())
            {
                isCorrect = false;
                message.Append("Дата рождения\n");
            }
            messages = message.ToString();
            return isCorrect;
            
        }

        private void InFile(String text)
        {
            string writePath = @"C:\Users\Nikto\source\repos\Questionnaire\Questionnaire\anketa.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                    sw.WriteLine("-------------------------------------------------------------");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String message = "";
            if (isDataCorrect(ref message))
            {
                MessageBox.Show("Данные введены корректно", "Уведомление");
                StringBuilder text = new StringBuilder();
                text.Append(SurnameTextBox.Text + "\n");
                text.Append(NameTextBox.Text + "\n");
                text.Append(LastnameTextBox.Text + "\n");
                if (ManButton.Checked)
                    text.Append("мужской" + "\n");
                else if (WomanButton.Checked)
                    text.Append("женский" + "\n");
                text.Append(DaysBox.Text +
                        " " + MonthsBox.Text +
                        " " + YearsBox.Text + "\n");
                text.Append(CityBox.Text + " " + StreetBox.Text + "\n");
                text.Append(EmailAdressBox.Text + "\n");
                text.Append(MobilePhone.Text + "\n");
                if (WorkExperienceButton1.Checked)
                    text.Append("Прежде не работал" + "\n");
                else if (WorkExperienceButton2.Checked)
                    text.Append("Меньше 1 года" + "\n");
                else if (WorkExperienceButton3.Checked)
                    text.Append("От 1 года до 5" + "\n");
                else if (WorkExperienceButton4.Checked)
                    text.Append("От 5 до 9 лет" + "\n");
                else if (WorkExperienceButton5.Checked)
                    text.Append("10 лет и больше" + "\n");
               text.Append("от " + MinWage.Text + " до " + MaxWage.Text + "\n");

                if (CarAvailabilityBox.Checked)
                    text.Append("авто имеется" + "\n");
                else
                    text.Append("авто отсутствует" + "\n");

                if (DriversLicenseBox.Checked)
                    text.Append("права имеются" + "\n");
                else
                    text.Append("права отсутствуют" + "\n");

                string category = "Категории: ";
                if (CategoryABox.Checked)
                    category += "A ";
                else if (CategoryBBox.Checked)
                    category += "B ";
                else if (CategoryCBox.Checked)
                    category += "C ";
                else if (CategoryDBox.Checked)
                    category += "D ";
                text.Append(category + "\n");

                if (ScheduleButton1.Checked)
                    text.Append("Полная занятость" + "\n");
                else if (ScheduleButton2.Checked)
                    text.Append("Частичная занятость" + "\n");
                else if (ScheduleButton3.Checked)
                    text.Append("Работа на дому" + "\n");
                else if (ScheduleButton4.Checked)
                    text.Append("Посменная работа" + "\n");

                if (ResumeBox.Text != "")
                    text.Append(ResumeBox.Text);

                InFile(text.ToString());
            }
            else
                MessageBox.Show(message, "Уведомление");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SurnameTextBox.Text = "";
            NameTextBox.Text = "";
            LastnameTextBox.Text = "";
            DaysBox.Text = "";
            MonthsBox.Text = "";
            YearsBox.Text = "";
            ManButton.Checked = true;
            CityBox.Text = "";
            StreetBox.Text = "";
            EmailAdressBox.Text = "";
            MobilePhone.Text = "";
            OperatorBox.Text = "";
            WorkExperienceButton1.Checked = true;
            MinWage.SelectedItem = MinWage.Items[0];
            MaxWage.SelectedItem = MaxWage.Items[0];
            CarAvailabilityBox.Checked = false;
            DriversLicenseBox.Checked = false;
            CategoryABox.Checked = false;
            CategoryBBox.Checked = false;
            CategoryCBox.Checked = false;
            CategoryDBox.Checked = false;
            ScheduleButton1.Checked = true;
            ResumeBox.Text = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Сообщение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }
    }
}
