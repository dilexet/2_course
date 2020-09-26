using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_library;

namespace Student_projects
{
    struct Student
    {
        public string Name;
        public string Surname;
        public int[][] laboratory;
        public double[] AverageGrade;
    }
    /// <summary>
    /// Класс для работы с файлами
    /// </summary>
    class work_with_file
    {
        /// <summary>
        /// Заполняет Student данными о лабораторных
        /// </summary>
        /// <param name="students"></param>
        public static void OutputLaboratory(ref Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Список студентов пуст");
                return;
            }
            string path = @"C:\Users\Nikto\source\repos\Student_projects\Student_projects\Laboratory.txt";
            string[] arr_data = File.ReadAllLines(path);

            if (arr_data.Length == 0)
            {
                Console.WriteLine("Данных нет!");
                return;
            }

            uint.TryParse(arr_data[0], out uint number_of_laboratory);
            for (int i = 0; i < students.Length; i++)
            {
                students[i].laboratory = new int[number_of_laboratory][];
            }
            for (int k = 0; k < students.Length; k++)
            {
                int j = 0;
                for (int i = 0; i < arr_data[1].Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        uint.TryParse(Convert.ToString(arr_data[1][i]), out uint number_of_tasks);
                        students[k].laboratory[j] = new int[number_of_tasks];
                        j++;
                    }
                }
            }
            
        }
        /// <summary>
        /// Выделение памяти под массив
        /// </summary>
        /// <param name="students"></param>
        public static void ArrayCreation(ref Student[] students)
        {
            string path = @"C:\Users\Nikto\source\repos\Student_projects\Student_projects\Student.txt";
            string[] arr_data = File.ReadAllLines(path);

            if (arr_data.Length == 0)
            {
                Console.WriteLine("Данных нет!");
                return;
            }
            students = new Student[arr_data.Length];
        }
        /// <summary>
        /// Заполняет Student данными о ФИО
        /// </summary>
        /// <param name="students"></param>
        public static void OutputStudent(ref Student[] students)
        {
            string path = @"C:\Users\Nikto\source\repos\Student_projects\Student_projects\Student.txt";
            string[] arr_data = File.ReadAllLines(path);

            if (arr_data.Length == 0)
            {
                Console.WriteLine("Данных нет!");
                return;
            }
            students = new Student[arr_data.Length];
            for (int i = 0; i < arr_data.Length; i++)
            {
                string[] student = arr_data[i].Split(' ');
                students[i].Surname = student[0];
                students[i].Name = student[1];
            }
        }

        /// <summary>
        /// Сохранение данных в бинарном виде
        /// </summary>
        /// <param name="students"></param>
        public static void SavingВata(Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            string path3 = @"C:\Users\Nikto\source\repos\Student_projects\Student_projects\stud_lab.bin";
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path3, FileMode.OpenOrCreate)))
                {
                    // записываем в файл значение каждого поля структуры
                    foreach (var item in students)
                    {
                        writer.Write(item.Name);
                        writer.Write(item.Surname);
                        for (int i = 0; i < item.laboratory.Length; i++)
                        {
                            for (int j = 0; j < item.laboratory[i].Length; j++)
                            {
                                writer.Write(item.laboratory[i][j]);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Восстановление данных с бинарного файла
        /// </summary>
        /// <param name="students"></param>
        public static void RecoveryData(ref Student[] students)
        {
            string path3 = @"C:\Users\Nikto\source\repos\Student_projects\Student_projects\stud_lab.bin";
            
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path3, FileMode.Open)))
                {
                    
                    if (!(reader.PeekChar() > -1))
                    {
                        Console.WriteLine("Файл пуст");
                        return;
                    }
                    int k = 0;
                    ArrayCreation(ref students);
                    OutputLaboratory(ref students);
                    while (reader.PeekChar() > -1)
                    {
                        students[k].Name = reader.ReadString();
                        students[k].Surname = reader.ReadString();
                        for (int i = 0; i < students[k].laboratory.Length; i++)
                        {
                            for (int j = 0; j < students[k].laboratory[i].Length; j++)
                            {
                                students[k].laboratory[i][j] = reader.ReadInt32();
                            }
                        }
                        k++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class work_with_student
    {
        /// <summary>
        /// Выводит все данные о студентах
        /// </summary>
        /// <param name="students"></param>
        public static void StudentsProgressList(Student[] students)
        {
            if (students == null)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            CalculatingAverageGrade(ref students);
            foreach (var item in students)
            {
                Console.WriteLine("№Lab" + "\tСредний балл\t" + (item.Surname ?? "No") + " " + (item.Name ?? "Name"));
                for (int i = 0; i < item.laboratory.Length; i++)
                {
                    Console.Write("{0}\t{1:0.000}\t\t", i + 1, item.AverageGrade[i]);
                    for (int j = 0; j < item.laboratory[i].Length; j++)
                    {
                        Console.Write(item.laboratory[i][j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Выводит список студентов
        /// </summary>
        /// <param name="students"></param>
        public static void PrintListStudents(Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            int indexStudent = 1;
            foreach (var item in students)
            {
                Console.WriteLine("№ " + indexStudent + "\t" + (item.Surname ?? "No") + " " + (item.Name ?? "Name"));
                indexStudent++;
            }
        }

        /// <summary>
        /// Выводит успеваемость отдельного студента
        /// </summary>
        /// <param name="students"></param>
        public static void StudentProgressChart(Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            Console.Write("Введите номер студента: ");
            uint.TryParse(Console.ReadLine(), out uint number_student);
            if (number_student > students.Length)
            {
                Console.WriteLine("Студента с таким номер не существует");
                return;
            }
            Console.Clear();
            Console.WriteLine("№Lab" + "\t" + students[number_student - 1].Surname + " " + students[number_student - 1].Name);
            for (int i = 0; i < students[number_student - 1].laboratory.Length; i++)
            {
                Console.Write(i + 1 + "\t");
                for (int j = 0; j < students[number_student - 1].laboratory[i].Length; j++)
                {
                    Console.Write(students[number_student - 1].laboratory[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Список сданных лабораторных студентом
        /// </summary>
        /// <param name="students"></param>
        public static void ListCompletedWorks(Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            Console.Write("Введите номер студента: ");
            uint.TryParse(Console.ReadLine(), out uint number_student);
            if (number_student > students.Length)
            {
                Console.WriteLine("Студента с таким номер не существует");
                return;
            }
            Console.Clear();
            Console.WriteLine("№Lab" + "\t" + students[number_student - 1].Surname + " " + students[number_student - 1].Name);

            for (int i = 0; i < students[number_student - 1].laboratory.Length; i++)
            {
                Console.Write(i + 1 + "\t");
                string grade = "";
                for (int j = 0; j < students[number_student - 1].laboratory[i].Length; j++)
                {
                    if (students[number_student - 1].laboratory[i][j] == 0)
                    {
                        grade = "лабораторная не сдана полностью";
                        break;
                    }
                    else
                    {
                        grade += Convert.ToString(students[number_student - 1].laboratory[i][j]) + " ";
                    }
                }
                Console.Write(grade);
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Зполняет сданные работы рандомно
        /// </summary>
        public static void RandomGenerationGrades(Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            Random random = new Random();
            foreach (var item in students)
            {
                for (int i = 0; i < item.laboratory.Length; i++)
                {
                    for (int j = 0; j < item.laboratory[i].Length; j++)
                    {
                        item.laboratory[i][j] = random.Next(6);
                    }
                }

            }
            Console.WriteLine("Операция прошла успешно");
        }

        /// <summary>
        /// Заполние сданных работ пользователем
        /// </summary>
        /// <param name="students"></param>
        public static void FillingSubmitedWorks(Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            Console.Write("Номер студента в списке: ");
            uint.TryParse(Console.ReadLine(), out uint numberStudent);
            if (numberStudent > students.Length)
            {
                Console.WriteLine("Студента с таким номером не существует");
                return;
            }

            Console.Write("Номер лабораторной работы: ");
            uint.TryParse(Console.ReadLine(), out uint numberLaboratory);
            if (numberLaboratory > students[0].laboratory.Length)
            {
                Console.WriteLine("Номера такой лабораторной не существует");
                return;
            }

            Console.Write("Номер задания: ");
            uint.TryParse(Console.ReadLine(), out uint numberTask);
            if (numberTask > students[0].laboratory[numberLaboratory - 1].Length)
            {
                Console.WriteLine("В данной лабораторной работе нет такого задания");
                return;
            }
            Console.Write("Оценка: ");
            int.TryParse(Console.ReadLine(), out int grades);
            if (grades > 5 || grades < 0)
            {
                Console.WriteLine("Оценка введена неверно");
                return;
            }
            students[numberStudent - 1].laboratory[numberLaboratory - 1][numberTask - 1] = grades;
        }

        /// <summary>
        /// Средний балл по каждой лабораторной
        /// </summary>
        /// <param name="students"></param>
        public static void CalculatingAverageGrade(ref Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            int numberLaboratories = students[0].laboratory.Length;
            for (int i = 0; i < students.Length; i++) 
            {
                students[i].AverageGrade = new double[numberLaboratories];
                for (int j = 0; j < students[i].laboratory.Length; j++) 
                {
                    for (int k = 0; k < students[i].laboratory[j].Length; k++) 
                    {
                        students[i].AverageGrade[j] += students[i].laboratory[j][k];
                    }
                    students[i].AverageGrade[j] /= students[i].laboratory[j].Length;
                }
            }
        }

        /// <summary>
        /// Удаляет последнее задание в каждой лабораторной
        /// </summary>
        /// <param name="students"></param>
        public static void DeleteLastTask(ref Student[] students)
        {
            if (students == null || students.Length == 0)
            {
                Console.WriteLine("Список пуст");
                return;
            }
            Student[] temp_students = new Student[students.Length];
            for (int i = 0; i < temp_students.Length; i++)
            {
                temp_students[i].laboratory = new int[students[i].laboratory.Length][];
            }
            for (int i = 0; i < temp_students.Length; i++)
            {
                for (int j = 0; j < temp_students[i].laboratory.Length; j++) 
                {
                    temp_students[i].laboratory[j] = new int[students[i].laboratory[j].Length - 1];
                }
            }
            for (int i = 0; i < temp_students.Length; i++)
            {
                for (int j = 0; j < temp_students[i].laboratory.Length; j++)
                {
                    for (int k = 0; k < temp_students[i].laboratory[j].Length; k++)
                    {
                        temp_students[i].laboratory[j][k] = students[i].laboratory[j][k];
                    }
                }
            }
            for (int i = 0; i < temp_students.Length; i++)
            {
                students[i].laboratory = temp_students[i].laboratory;
            }
        }
    }
    class Program
    {
        static void test_main(ref Student[] students)
        {
            ConsoleKey consoleKey;
            do
            {
                Console.WriteLine("\n0. Восстановить данные;\n1. Считать данные о студентах;\n2. Считать данные о лабораторных;\n3. Заполнить оценки рандомом;" +
                    "\n4. Вывести список студентов и успеваемость;\n5. Вывести список студентов;\n6. Список сданных работ студента;\n" +
                    "7. Таблица успеваемости студента;\n8. Ввести данные о лабораторных\n9. Сохранить данные в бинарном виде;" +
                    "\nQ. Удалить последнее задание в каждой лабе;\nESC. Выход;\n");
                consoleKey = Console.ReadKey(true).Key;
                Console.Clear();
                switch (consoleKey)
                {
                    case ConsoleKey.Escape:
                        break;
                    case ConsoleKey.D1:
                        work_with_file.OutputStudent(ref students);
                        break;
                    case ConsoleKey.D2:
                        work_with_file.OutputLaboratory(ref students);
                        break;
                    case ConsoleKey.D3:
                        work_with_student.RandomGenerationGrades(students);
                        break;
                    case ConsoleKey.D4:
                        work_with_student.StudentsProgressList(students);
                        break;
                    case ConsoleKey.D5:
                        work_with_student.PrintListStudents(students);
                        break;
                    case ConsoleKey.D6:
                        work_with_student.ListCompletedWorks(students);
                        break;
                    case ConsoleKey.D7:
                        work_with_student.StudentProgressChart(students);
                        break;
                    case ConsoleKey.D8:
                        work_with_student.FillingSubmitedWorks(students);
                        break;
                    case ConsoleKey.D9:
                        work_with_file.SavingВata(students);
                        break;
                    case ConsoleKey.D0:
                        work_with_file.RecoveryData(ref students);
                        break;
                    case ConsoleKey.Q:
                        work_with_student.DeleteLastTask(ref students);
                        break;
                    default:
                        Console.WriteLine("Выбрана неверная операция");
                        break;
                }
            } while (consoleKey != ConsoleKey.Escape);
        }
        static void Main(string[] args)
        {
            Student[] students = null;
            test_main(ref students);
            
        }
    }
}