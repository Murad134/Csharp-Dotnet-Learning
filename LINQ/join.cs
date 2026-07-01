using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Result
{
    public int StudentId { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new()
        {
            new Student{Id=1,Name="Rahim"},
            new Student{Id=2,Name="Karim"}
        };

        List<Result> results = new()
        {
            new Result{StudentId=1,Marks=90},
            new Result{StudentId=2,Marks=85}
        };

        var data = students.Join(results,
                    s=>s.Id,
                    r=>r.StudentId,
                    (s,r)=>new
                    {
                        s.Name,
                        r.Marks
                    });

        foreach(var item in data)
        {
            Console.WriteLine($"{item.Name} {item.Marks}");
        }
    }
}