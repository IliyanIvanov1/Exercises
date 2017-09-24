using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var grades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var nameAndGrade = Console.ReadLine().Split(' ');
                var name = nameAndGrade[0];
                var grade = double.Parse(nameAndGrade[1]);

                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                }
                grades[name].Add(grade);
            }

            foreach (var nameAndGrades in grades)
            {
                Console.WriteLine($"{nameAndGrades.Key} -> {string.Join(" ",nameAndGrades.Value)} (avg: {nameAndGrades.Value.Average()})");
            }
        }
    }
}
