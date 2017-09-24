using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<int>> grades = new Dictionary<string, List<int>>();

        AddGrade(grades, "Pesho", 2);
        AddGrade(grades, "Mariika", 3);
        AddGrade(grades, "Pesho", 2);
        AddGrade(grades, "Todor", 2);
        AddGrade(grades, "Todor", 3);
        AddGrade(grades, "Mariika", 5);

        foreach (var namesAndGrades in grades)
        {
            Console.WriteLine($"{namesAndGrades.Key} -> {string.Join(" ",namesAndGrades.Value)}");
        }

        PrintGrades(grades);
    }

    private static void PrintGrades(Dictionary<string, List<int>> grades)
    {
        foreach (var name in grades.Keys)
        {
            Console.WriteLine("Grades of " + name + ":");
            foreach (var grade in grades[name])
            {
                Console.WriteLine(" - " + grade);
            }
        }
    }

    public static void AddGrade(Dictionary<string, List<int>> grades,string name,int grade)
    {
        if (!grades.ContainsKey(name))
        {
            grades[name] = new List<int>();
        }
        grades[name].Add(grade);    
    }
}

