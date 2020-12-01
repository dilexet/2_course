using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace laba15
{
    [Serializable]
    public class Employee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
        }

        public Employee(string surname, string name, string lastName, string gender, int age, double salary)
        {
            Surname = surname;
            Name = name;
            LastName = lastName;
            Gender = gender;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"FIO: {Surname} {Name} {LastName}\nGender: {Gender}\nAge: {Age}\nSalary: {Salary}\n";
        }
    }
    internal class Program
    {
        static int max(int a, int b)
        {
            return a > b ? a : b;
        }
        static int min(int a, int b)
        {
            return a < b ? a : b;
        }
        
        
        static void Task_1_1()
        {
            string s1 = "hello my world";
            string s2 = "dlrow m olleh";
            Stack<char> _s1 = new Stack<char>();
            foreach (var item in s1)
            {
                _s1.Push(item);
            }

            bool flag = true;
            foreach (var item in s2)
            {
                if (item != _s1.Pop())
                {
                    flag = false;
                }
            }

            Console.WriteLine("{0}", (flag) ? "s2 обратна s1" : "s2 не обратна s1");
        }
        static void Task_1_2()
        {
            string expression = "*-567"; // (5 - 6) * 7 = -1 * 7 = -7
            Stack<int> numbers = new Stack<int>();
            int result = 0;
            for (int i = expression.Length - 1; i >= 0; i--) 
            {
                if (expression[i] == '+')
                {
                    result = numbers.Pop() + numbers.Pop();
                    numbers.Push(result);
                    continue;
                }
                if (expression[i] == '-')
                {
                    result = numbers.Pop() - numbers.Pop();
                    numbers.Push(result);
                    continue;
                }
                if (expression[i] == '*')
                {
                    result = numbers.Pop() * numbers.Pop();
                    numbers.Push(result);
                    continue;
                }
                if (expression[i] == '/')
                {
                    result = numbers.Pop() / numbers.Pop();
                    numbers.Push(result);
                    continue;
                }

                if (expression[i] != '+' || expression[i] != '-' || expression[i] != '*' || expression[i] != '/')
                {
                    
                    numbers.Push(Convert.ToInt32(expression[i]) - 48);
                }
            }

            Console.WriteLine(numbers.Pop());
        }
        static void Task_1_3()
        {
            string formula = "M(m(9,5),M(7,2))";
            Stack<char> Formula = new Stack<char>();
            Stack<int> value = new Stack<int>();
            string line = "";
            using (StreamReader sr = new StreamReader("text_1_3.txt"))
            {
                if ((line = sr.ReadLine()) != null)
                {
                    formula = line;
                }
            }
            foreach (var item in formula)
            {
                Formula.Push(item);
            }
            
            foreach (var item in Formula)
            {
                if (item == 'm')
                {
                    int a = value.Pop();
                    int b = value.Pop();
                    value.Push(min(a, b));
                }

                if (item == 'M')
                {
                    int a = value.Pop();
                    int b = value.Pop();
                    value.Push(max(a, b));
                }
                if (Convert.ToInt32(item) >= 48 && Convert.ToInt32(item) <= 57)
                {
                    value.Push(Convert.ToInt32(item) - 48);
                }
            }

            Console.WriteLine(value.Pop());
        }
        static void Task_1_4()
        {
            string str = "abc#d##c";
            Stack<char> _chars = new Stack<char>();
            foreach (var item in str)
            {
                if (item == '#')
                {
                    _chars.Pop();
                    continue;
                }
                _chars.Push(item);
            }

            str = "";
            foreach (var item in _chars)
            {
                str += item;
            }

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }

        static void Task_2_1()
        {
            Queue<int> valuesFromTheInterval = new Queue<int>();
            Queue<int> valuesLessThanInterval = new Queue<int>();
            Queue<int> valuesGreaterThanInterval = new Queue<int>();
            string line = "";
            char[] separator = {' ', ',', '.', '!', '?'};
            int a = 5;
            int b = 10;
            using (StreamReader sr = new StreamReader("text_2_1.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    foreach (var value in line.Split(separator, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (Convert.ToInt32(value) >= a && Convert.ToInt32(value) <= b)
                            valuesFromTheInterval.Enqueue(Convert.ToInt32(value));
                        else if (Convert.ToInt32(value) < a)
                            valuesLessThanInterval.Enqueue(Convert.ToInt32(value));
                        else if (Convert.ToInt32(value) > b)
                            valuesGreaterThanInterval.Enqueue(Convert.ToInt32(value));
                    }
                }
            }

            foreach (var item in valuesFromTheInterval)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
            foreach (var item in valuesLessThanInterval)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            foreach (var item in valuesGreaterThanInterval)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
        static void Task_2_2()
        {
            Queue<string> WordsA = new Queue<string>();
            Queue<string> WordsB = new Queue<string>();
            string line;
            char[] separator = {' ', ',', '.', '!', '?'};
            char[] filterArray =
            {
                'а', 'A', 'у', 'У', 'о', 'О', 'ы', 'Ы', 'и', 'И', 'э', 'Э', 'я', 'Я', 'ю', 'ю', 'ё', 'Ё', 'е', 'Е'
            };
            using (StreamReader sr = new StreamReader("text_2_2.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    foreach (var word in line.Split(separator, StringSplitOptions.RemoveEmptyEntries))
                    {
                        bool b = true;
                        foreach (var item in filterArray)
                        {
                            if (word[0] == item)
                            {
                                WordsA.Enqueue(word);
                                b = false;
                            }
                        }

                        if (b)
                            WordsB.Enqueue(word);
                    }
                }
            }

            foreach (var wordA in WordsA)
            {
                Console.Write($"{wordA}\t");
            }

            Console.WriteLine();

            foreach (var wordA in WordsB)
            {
                Console.Write($"{wordA}\t");
            }
        }
        static void Task_2_3()
        {
            string line = "";
            char[] separator = {' ', ',', '.', '!', '?'};
            Queue<string> Upp = new Queue<string>();
            Queue<string> Lowwer = new Queue<string>();
            
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            using (StreamReader sr = new StreamReader("text_2_3.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    foreach (var word in line.Split(separator, StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (word == textInfo.ToTitleCase(word))
                            Upp.Enqueue(word);
                        else
                            Lowwer.Enqueue(word);
                    }
                }
            }

            foreach (var item in Upp)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
            foreach (var item in Lowwer)
            {
                Console.Write($"{item}\t");
            }
        }
        static void Task_2_4()
        {
            /*
            Employee employee1 = 
                new Employee("Povargo", "Maksim", "Valerevich", "men", 18, 350000);
            Employee employee2 = 
                new Employee("Ivanov", "Ivan", "Ivanovich", "men", 35, 548992);
            Employee employee3 = 
                new Employee("Petr", "Petrov", "Petrovich", "men", 44, 393895);
            Employee employee4 = 
                new Employee("Arkadij", "Parovozov", "Akakevich", "men", 19, 380028);
            XmlSerializer formatter = new XmlSerializer(typeof(Employee[]));
            Employee[] employees = new Employee[]
            {
                employee1,
                employee2,
                employee3,
                employee4
            };
            using (FileStream fs = new FileStream("text_2_4.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, employees);
            }
            */
            XmlSerializer formatter = new XmlSerializer(typeof(Employee[]));
            Queue<Employee> employees1 = new Queue<Employee>();
            Queue<Employee> employees2 = new Queue<Employee>();
            using (FileStream fs = new FileStream("text_2_4.xml", FileMode.OpenOrCreate))
            {
                Employee[] employees = (Employee[])formatter.Deserialize(fs);
 
                foreach (var employee in employees)
                {
                    if (employee.Age < 30)
                        employees1.Enqueue(employee);
                    else if (employee.Age >= 30) 
                        employees2.Enqueue(employee);
                }
            }

            foreach (var item in employees1)
            {
                Console.Write(item.ToString());
            }

            Console.WriteLine();
            foreach (var item in employees2)
            {
                Console.Write(item.ToString());
            }
        }
        
        public static void Main(string[] args)
        {
            
        }
    }
}



