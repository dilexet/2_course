using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
namespace laba14
{
    [Serializable]
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public string Address { get; set; }
        public int NumberGroup { get; set; }
        
        public int[] ExamGrades = new int[3];

        public List<Student> Students = new List<Student>();

        public Student()
        {
        }
        public Student(string Name, string Surname, string LastName, int YearOfBirth, string Address, int[] ExamGrades, int NumberGroup)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.LastName = LastName;
            this.YearOfBirth = YearOfBirth;
            this.Address = Address;
            this.ExamGrades[0] = ExamGrades[0];
            this.ExamGrades[1] = ExamGrades[1];
            this.ExamGrades[2] = ExamGrades[2];
            this.NumberGroup = NumberGroup;
        }

        public int CompareTo(Student student)
        {
            return this.YearOfBirth.CompareTo(student.YearOfBirth);
        }
        public override string ToString()
        {
            return $"{Surname} {Name} {LastName}, {YearOfBirth}, {Address}, {ExamGrades[0]}/{ExamGrades[1]}/{ExamGrades[2]}, {NumberGroup}";
        }

        public void FileRead(string path = "input.xml")
        {
            XmlSerializer formatter =  new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                Students = (List<Student>) formatter.Deserialize(fs);
            }
            /*
            XDocument xdoc = XDocument.Load(path);
            foreach (XElement studentElement in xdoc.Element("Students").Elements("Student"))
            {
                XElement NameElement = studentElement.Element("Name");
                XElement SurnameElement = studentElement.Element("Surname");
                XElement LastNameElement = studentElement.Element("LastName");
                XElement YearBirthElement = studentElement.Element("YearBirth");
                XElement AddressElement = studentElement.Element("Address");
                XElement NumberGroupElement = studentElement.Element("NumberGroup");
                XElement Grade1Element = studentElement.Element("Grade1");
                XElement Grade2Element = studentElement.Element("Grade2");
                XElement Grade3Element = studentElement.Element("Grade3");
                if (NameElement != null && SurnameElement != null && LastNameElement != null &&
                    YearBirthElement != null && AddressElement != null && NumberGroupElement != null &&
                    Grade1Element != null && Grade2Element != null && Grade3Element != null) 
                {
                    int[] grade =
                    {
                        int.Parse(Grade1Element.Value), int.Parse(Grade2Element.Value), int.Parse(Grade3Element.Value)
                    };
                    Students.Add(new Student(NameElement.Value, SurnameElement.Value, LastNameElement.Value,
                        int.Parse(YearBirthElement.Value), AddressElement.Value, grade,
                        int.Parse(NumberGroupElement.Value)));
                }
            }
            */
        }

        public void FileWrite(string path = "output.xml")
        {
            XmlSerializer formatter =  new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Students);
            }

            /*
            XDocument xdoc = XDocument.Load(path);
            XElement root = xdoc.Element("Students");
            foreach (var item in Students)
            {
                root.Add(new XElement("Student",
                    new XAttribute("Name", item.Name),
                    new XElement("Surname", item.Surname),
                    new XElement("LastName", item.LastName),
                    new XElement("YearBirth", item.YearOfBirth),
                    new XElement("Address", item.Address),
                    new XElement("NumberGroup", item.NumberGroup),
                    new XElement("Grade1", item.ExamGrades[0]),
                    new XElement("Grade2", item.ExamGrades[1],
                    new XElement("Grade3", item.ExamGrades[2])
                )));
            }
            
            xdoc.Save(path);
            */
        }
        public void SortStudent()
        {
            var ItemStudents = from student in Students
                where student.ExamGrades[0] >= 4 && student.ExamGrades[1] >= 4 && student.ExamGrades[2] >= 4
                orderby student.NumberGroup
                select student;
            Students = ItemStudents.ToList();
        }
    }
    class Program
    {
        // криво записывает оценки за экзамен в файл
        static void Main(string[] args)
        {
            
            Student student = new Student();
            /*
            student.Students.Add(
                new Student("Povargo", "Maksim", "Valerevich", 2002, "Devetovka", new int[] {9, 5, 4}, 191));
            student.Students.Add(
                new Student("Parovozov", "Arkadiy", "Andreevich", 2001, "Brikela", new int[] {3, 2, 5}, 193));
            student.Students.Add(
                new Student("Runov", "Andrey", "Ivanovich", 2003, "Tavlaya", new int[] {8, 4, 6}, 192));
                */
            
            student.FileRead();
            //student.Students.Sort();
            student.SortStudent();
            student.FileWrite();

        }
    }
}