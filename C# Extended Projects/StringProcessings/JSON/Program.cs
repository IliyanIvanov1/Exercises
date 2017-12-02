using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int[] Grades { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            var inputLine = Console.ReadLine();

            while (inputLine!="stringify")
            {
                var inputParams = inputLine.Split(new[] { ' ', ':', '>', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var studentName = inputParams[0];
                var studentAge = int.Parse(inputParams[1]);
                var studentGrades = inputParams.Skip(2).Select(int.Parse).ToArray();

                Student newStudent = new Student();

                newStudent.Name = studentName;
                newStudent.Age = studentAge;
                newStudent.Grades = studentGrades;

                students.Add(newStudent);

                inputLine = Console.ReadLine();
            }
                Console.WriteLine(
                    "[" + string.Join(",",students.Select(student => $"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}}")) + "]");
        }
    }
}
