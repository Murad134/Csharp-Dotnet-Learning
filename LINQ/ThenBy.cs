using System;
using System.Linq;
namespace MyApplication
{
    class Student
    {
        public string Name{get; set;}
        public int Age{get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student>students = new List<Student>()
            {
                new Student{Name="John",Age=18},
                new Student{Name="Alice",Age=20},
                new Student{Name="Bob",Age=19},
                new Student{Name="Eve",Age=21}
            };

            var result =students.OrderBy(s=> s.Age).ThenBy(s=> s.Name);
            Console.WriteLine("Students sorted by age and then by name:");
            foreach(var student in result)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}