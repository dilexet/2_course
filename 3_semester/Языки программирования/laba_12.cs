using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Xml;

namespace laba12
{
    class MyArray
        {
            public int[] IntArray { get; }
            public int Lenght { get; }

            public int MultipyByScalar
            {
                set
                {
                    for (int i = 0; i < Lenght; i++)
                    {
                        IntArray[i] *= value;
                    }
                }
            }

            public int Max
            {
                get
                {
                    int max = IntArray[0];
                    foreach (var item in IntArray)
                    {
                        if (item > max)
                            max = item;
                    }
                    return max;
                }
            }

            public int Min
            {
                get
                {
                    int min = IntArray[0];
                    foreach (var item in IntArray)
                    {
                        if (item < min)
                            min = item;
                    }
                    return min;
                }
            }

            public int Sum
            {
                get
                {
                    int sum = 0;
                    foreach (var item in IntArray)
                    {
                        sum += item;
                    }
                    return sum;
                }
            }

            public int this[int index]
            {
                get
                {
                    return IntArray[index];
                }
                set
                {
                    IntArray[index] = value;
                }
            }
            
            /// <summary>
            /// Выделяет память под массив
            /// </summary>
            /// <param name="Lenght"></param>
            public MyArray(int Lenght) : this(Lenght, 0, 0){ }
            
            /// <summary>
            /// Заполняет случайными числами из отрезка
            /// </summary>
            /// <param name="Lenght"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            public MyArray(int Lenght, int min, int max) : this(Lenght, min, max, false){ }

            /// <summary>
            /// Заполяет случайными числами из отрезка и сортирует по возрастанию
            /// </summary>
            /// <param name="Lenght"></param>
            /// <param name="min"></param>
            /// <param name="max"></param>
            /// <param name="sort"></param>
            public MyArray(int Lenght, int min, int max, bool sort)
            {
                this.Lenght = Lenght;
                IntArray = new int[this.Lenght];
                Random random = new Random();
                for (int i = 0; i < this.Lenght; ++i)
                {
                    IntArray[i] = random.Next(min, max);
                }
                if (sort)
                    Sort();
            }

            /// <summary>
            /// Заполнение массив с клавиатуры
            /// </summary>
            public void Input()
            {
                if (Lenght <= 0)
                {
                    Console.WriteLine("Array is empty");
                    return;
                }
                for (int i = 0; i < Lenght; ++i)
                {
                    IntArray[i] = int.Parse(Console.ReadLine());
                }
            }

            /// <summary>
            /// Вывод элемнтов массива
            /// </summary>
            public void Output()
            {
                if (Lenght <= 0)
                {
                    Console.WriteLine("Array is empty");
                    return;
                }
                foreach (var item in IntArray)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
            }

            /// <summary>
            /// Сортирует массив
            /// </summary>
            public void Sort()
            {
                Array.Sort(IntArray);
            }

            public static MyArray operator ++(MyArray myArray)
            {
                for (int i = 0; i < myArray.Lenght; ++i)
                {
                    ++myArray.IntArray[i];
                }
                return myArray;
            }
            
            public static MyArray operator --(MyArray myArray)
            {
                for (int i = 0; i < myArray.Lenght; ++i)
                {
                    --myArray.IntArray[i];
                }
                return myArray;
            }

            public static bool operator !(MyArray myArray)
            {
                for (int i = 0; i < myArray.Lenght - 1; ++i)
                {
                    if (myArray.IntArray[i] > myArray.IntArray[i + 1])
                        return true;
                }

                return false;
            }

            public static MyArray operator *(MyArray myArray, int scalar)
            {
                myArray.MultipyByScalar = scalar;
                return myArray;
            }
            
            public static explicit operator int[](MyArray myArray)
            {
                return myArray.IntArray;
            }
            
            public static explicit operator MyArray(int[] array)
            {
                MyArray myArray = new MyArray(array.Length);
                array.CopyTo(myArray.IntArray, 0);
                return myArray;
            }
            
        }

    class Date
    {
        public bool DateIsCorrect()
        {
            if (Month > 12 || Month < 1)
                return false;
            if (Day < 1 || Day > 31)
                return false;
            if ((Month == 4 || Month == 6 || Month == 9 || Month == 11) && Day > 30)
                return false;
            if (Month == 2)
            {
                if (Year % 4 == 0 && (Year % 100 != 0 || Year % 400 == 0))
                {
                    if (Day > 29)
                        return false;
                }
                else
                {
                    if (Day > 28)
                        return false;
                }
            }
            return true;
        }
        private uint Day { get; set; }
        private uint Month { get; set; }
        private uint Year { get; set; }

        private string[] RusMonth =
        {
            "Январь", "Февраль", "Март",
            "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь",
            "Октябрь", "Ноябрь", "Декабрь"
        };

        private string[] EnMonth =
        {
            "January", "February", "March",
            "April", "May", "June",
            "July", "August", "September",
            "October", "November", "December"
        };
        
        public Date this[int index]
        {
            get
            {
                bool b = false;
                if (index < 0)
                {
                    b = true;
                    index *= (-1);
                }
                for (int i = 0; i < index; i++)
                {
                    if (b)
                        PrevDay();
                    else
                        NextDay();
                }

                Date date = new Date(Day, Month, Year);
                return date;
            }
        }
        
        public Date():this(1,1){ }
        public Date(uint Day, uint Month, uint Year = 2011)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
            if (!DateIsCorrect())
                Console.WriteLine("Error: Date is invalid.");
        }

        public Date(string date)
        {
            char[] separator = {'/', '.'};
            var item = date.Split(separator);
            this.Day = uint.Parse(item[0]);
            this.Month = uint.Parse(item[1]);
            this.Year = uint.Parse(item[2]);
            if (!DateIsCorrect())
                Console.WriteLine("Error: Date is invalid.");
        }
        public override string ToString()
        {
            if (Day < 10 && Month < 10) 
                return $"0{Day}/0{Month}/{Year}";
            if (Day < 10) 
                return $"0{Day}/{Month}/{Year}";
            if (Month < 10) 
                return $"{Day}/0{Month}/{Year}";
            return $"{Day}/{Month}/{Year}";
        }

        public void ConsoleWriteDate()
        {
            Console.WriteLine(ToString());
        }
        
        public void ConsoleWriteDateRu()
        {
            Console.WriteLine($"{RusMonth[Month - 1]}, {Day}, {Year}");
        }
        
        public void ConsoleWriteDateEn()
        {
            Console.WriteLine($"{EnMonth[Month - 1]}, {Day}, {Year}");
        }
        
        public bool IsLast()
        {
            if ((Month == 4 || Month == 6 || Month == 9 || Month == 11) && Day == 30)
                return true;
            if (Month == 2)
            {
                if (Year % 4 == 0 && (Year % 100 != 0 || Year % 400 == 0))
                {
                    if (Day == 29)
                        return true;
                }
                else
                {
                    if (Day == 28)
                        return true;
                }
            }
            if ((Month == 1 || Month == 3 || Month == 5 || Month == 7 ||
                 Month == 8 || Month == 10 || Month == 12) && Day == 31)
                return true;
            return false;
        }
        public Date NextDay()
        {
            if (Month == 12 && Day == 31)
            {
                Year++;
                Month = 1;
                Day = 1;
            }
            else if (IsLast())
            {
                Month++;
                Day = 1;
            }
            else
                Day++;
            
            Date date = new Date(Day, Month, Year);
            return date;
        }
        private uint GetLastDayOfTheMonth(uint month, uint year)
        {
            if (month == 4 || month == 6 || month == 9 || month == 11)
                return 30;
            if (month == 2)
            {
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                    return 29;
                else
                    return 28;
            }
            return 31;
        }
        
        public Date PrevDay()
        {
            Date date;
            if (Day == 1 && Month != 1) 
            {
                Month--;
                Day = GetLastDayOfTheMonth(Month, Year);
                date = new Date(Day, Month, Year);
                return date;
            }
            if (Day == 1 && Month == 1)
            {
                Year--;
                Month = 12;
                Day = GetLastDayOfTheMonth(Month, Year);
                date = new Date(Day, Month, Year);
                return date;
            }
            if (Day > 1)
                Day--;
            date = new Date(Day, Month, Year);
            return date;
        }
        
        public Date After(int CountDays)
        {
            for (int i = 0; i < CountDays; i++)
            {
                NextDay();
            }
            Date date = new Date(Day, Month, Year);
            return date;
        }
        
        public int Between(Date date)
        {
            int count = 0;
            while (true)
            {
                NextDay();
                count++;
                if (Day == date.Day && Month == date.Month && Year == date.Year)
                    break;
            }
            return count;
        }

        public static bool operator !(Date date)
        {
            if (date.IsLast())
                return true;
            return false;
        }
        
        public static bool operator true(Date date)
        {
            return date.Day == 1 && date.Month == 1;
        }
        public static bool operator false(Date date)
        {
            return date.Day != 1 && date.Month != 1;
        }

        public static bool operator &(Date date1, Date date2)
        {
            if (date1.Day == date2.Day && date1.Month == date2.Month && date1.Year == date2.Year)
                return true;
            return false;
        }
        
        public static explicit operator string(Date date)
        {
            return date.ToString();
        }
            
        public static explicit operator Date(string datestr)
        {
            Date date = new Date(datestr);
            return date;
        }

        public static bool operator >(Date date1, Date date2)
        {
            if (date1.Year > date2.Year)
                return true;
            if (date1.Month > date2.Month)
                return true;
            if (date1.Day > date2.Day)
                return true;
            return false;
        }
        public static bool operator <(Date date1, Date date2)
        {
            if (date1.Year < date2.Year)
                return true;
            if (date1.Month < date2.Month)
                return true;
            if (date1.Day < date2.Day)
                return true;
            return false;
        }
       
    }

    class User
    {
        private string Surname;
        private string Login;
        private string Password;
        private Date date;
        private List<User> users = new List<User>();
        public User(string Surname, string Login, string Password, string date)
        {
            this.Surname = Surname;
            this.Login = Login;
            this.Password = Password;
            this.date = new Date(date);
        }

        public User()
        {
            
        }
        public override string ToString()
        {
            return $"\nSurname: {Surname};\nLogin: {Login};\nPassword: {Password};\nDate: {date};";
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        private void ReadFile()
        {
            XDocument xdoc = XDocument.Load("Users.xml");
            foreach (XElement phoneElement in xdoc.Element("Users").Elements("User"))
            {
                XAttribute SurnameAttribute = phoneElement.Attribute("Surname");
                XElement LoginElement = phoneElement.Element("Login");
                XElement PasswordElement = phoneElement.Element("Password");
                XElement DateElement = phoneElement.Element("Date");
                if (SurnameAttribute != null && LoginElement != null && PasswordElement != null &&
                    DateElement != null)
                {
                    users.Add(new User(SurnameAttribute.Value.ToString(), LoginElement.Value.ToString(),
                        PasswordElement.Value.ToString(), DateElement.Value.ToString()));
                }
            }
        }

        private void WriteFile(string surname, string login, string password, Date date)
        {
            XDocument xdoc = XDocument.Load("Users.xml");
            XElement root = xdoc.Element("Users");
            root.Add(new XElement("User",
                new XAttribute("Surname", surname),
                new XElement("Login", login),
                new XElement("Password", password),
                new XElement("Date", date.ToString())
                ));
            xdoc.Save("Users.xml");
        }

        private void EditFile(string password, string surname)
        {
            XDocument xdoc = XDocument.Load("Users.xml");
            XElement root = xdoc.Element("Users");
 
            foreach (XElement xe in root.Elements("User").ToList())
            {
                if (xe.Attribute("Surname").Value == surname)
                {
                    xe.Element("Password").Value = password;
                    break;
                }
            }
            xdoc.Save("Users.xml");
        }

        public void Authorization()
        {
            ReadFile();
            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
        
            foreach (var user in users)
            {
                if (user.Login == login && user.Password == password)
                {
                    Date TodayDate = new Date(DateTime.Now.ToShortDateString()); // 13/11/2020
                    Date date = new Date(user.date.ToString()); // 11/11/2020
                    if (TodayDate > date)
                    {
                        Console.Write("New Password: ");
                        password = Console.ReadLine();
                        EditFile(password, user.Surname);
                    }
                    else
                    {
                        int CountDay = TodayDate.Between(date);
                        Console.WriteLine(CountDay);
                    }
                    return;
                }
            }

            Console.WriteLine("Register: ");
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            var Todaydate = DateTime.Now.AddDays(90);
            WriteFile(surname, login, password, new Date(Todaydate.ToShortDateString()));
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}