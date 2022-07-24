using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < count; i++)
            {
                string[] student = Console.ReadLine().Split(' ');
                string name = student[0];
                decimal grade = decimal.Parse(student[1]);
                if (!students.ContainsKey(student[0]))
                {
                    students[name]= new List<decimal>();
                    students[name].Add(grade);
                }
                else
                {
                    students[student[0]].Add(grade);
                }
            }
            foreach (var student in students)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                        Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
