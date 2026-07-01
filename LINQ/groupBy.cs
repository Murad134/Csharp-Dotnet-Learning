using System;
using System.Collections.Generic;
using System.Linq;
class Student
{
    public string Name { get; set; }
    public string Department { get; set; }
}
namespace MyAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{Name ="Murad", Department="Cse"},
                new Student{Name ="Ali", Department="Cse"},
                new Student{Name ="Ahmed", Department="Cse"},
                new Student{Name ="Hassan", Department="It"},
                new Student{Name ="Haris", Department="It"},
                new Student{Name ="Haris", Department="It"},
            };
            var groups = students.GroupBy(s => s.Department);
            foreach (var group in groups)
            {
                Console.WriteLine($"Department: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"Student Name: {student.Name}");
                }
            }
        }
    }
}