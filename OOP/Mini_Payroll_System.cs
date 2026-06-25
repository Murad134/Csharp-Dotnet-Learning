using System;

abstract class Employee
{
    private decimal salary;   // Encapsulation

    public string Name { get; set; }

    public decimal Salary
    {
        get => salary;
        set
        {
            if (value >= 0)
                salary = value;
        }
    }

    public abstract decimal CalculateBonus();  // Abstraction + Polymorphism

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"Bonus: {CalculateBonus()}");
        Console.WriteLine();
    }
}

class Developer : Employee                      // Inheritance
{
    public override decimal CalculateBonus()
    {
        return Salary * 0.15m;
    }
}

class Manager : Employee
{
    public override decimal CalculateBonus()
    {
        return Salary * 0.25m;
    }
}

class Program
{
    static void Main()
    {
        Employee dev = new Developer
        {
            Name = "Murad",
            Salary = 50000
        };

        Employee manager = new Manager
        {
            Name = "Adiba",
            Salary = 80000
        };

        dev.DisplayInfo();
        manager.DisplayInfo();
    }
}