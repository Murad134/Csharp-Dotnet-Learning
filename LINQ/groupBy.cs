using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Murad", Department = "CSE" },
            new Student { Name = "Rakib", Department = "EEE" },
            new Student { Name = "Akash", Department = "CSE" },
            new Student { Name = "Hasan", Department = "BBA" },
            new Student { Name = "Sakib", Department = "EEE" }
        };

        var result = students.GroupBy(s => s.Department);

        foreach (var group in result)
        {
            Console.WriteLine($"Department: {group.Key}");

            foreach (var student in group)
            {
                Console.WriteLine($"   {student.Name}");
            }

            Console.WriteLine();
        }
    }
}