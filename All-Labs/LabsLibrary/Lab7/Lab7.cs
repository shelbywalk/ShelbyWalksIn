using LabsInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace LabsLibrary.Lab7
{
    internal class Lab7 : ILabs
    {
        /// <summary>
        /// Метод демоснтрации лабораторной
        /// </summary>
        public void Demo()
        {
            for (int i = 0; i < 1; i++)
            {
                Group.AddStudent();
            }
            string[] students = new string[Group.StudentCount()];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = Group.StudentsInfo();

                Console.WriteLine(students[i]);

            }
            var jsoneFormater = new DataContractJsonSerializer(typeof(string[]));
            using (var file = new FileStream("students.jsone", FileMode.OpenOrCreate))
            {
                jsoneFormater.WriteObject(file, students);
            }
        }

        /// <summary>
        /// Метод выполнения описания
        /// </summary>
        /// <returns>Описания лабораторной</returns>
        public string Description()
        {
            return "Задания лабораторной №7";
        }

        /// <summary>
        /// Метод возвращает номер лабы
        /// </summary>
        /// <returns>Номер лабораторной</returns>
        public int Id()
        {
            return 7;
        }

        /// <summary>
        /// Метод возвращает заголовок лабораторной работы 
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Лабораторная работа №7.\nТема: Сериализация";
        }
    }
}
