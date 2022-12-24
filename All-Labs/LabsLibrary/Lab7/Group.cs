using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabsLibrary.Lab7
{
    public class Group
    {
        public void AddStudent(List<Student> students)
        {
            students = _students;
        }
        private static List<Student> _students = new List<Student>();
        public static void AddStudent()
        {
            _students.Add(new Student());
            AddStudentInfo();
        }
        private static void AddStudentInfo()
        {
            foreach (Student student in _students)
            {
                Console.WriteLine("Введите имя");
                student.Name = Console.ReadLine();
                Console.WriteLine("Введите пол");
                student.Gender = Console.ReadLine();
                Console.WriteLine("Введите возраст");
                student.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ВУЗ/ССУЗ");
                student.Institution = Console.ReadLine();
                Console.WriteLine("Введите специальность");
                student.Specialization = Console.ReadLine();
                Console.WriteLine("Введите группу");
                student.Group = Console.ReadLine();
            }
        }
        public static int StudentCount()
        {
            int count = 0;
            foreach (Student student in _students)
            {
                count++;
            }

            return count;
        }
        public static string StudentsInfo()
        {
            foreach (Student student in _students)
            {
                return ($"Имя: {student.Name}, Пол: {student.Gender}, Возраст: {student.Age}, ВУЗ/ССУЗ: {student.Institution}, Специальность: {student.Specialization} Группа: {student.Group}");
            }
            return "";
        }
    }
}
