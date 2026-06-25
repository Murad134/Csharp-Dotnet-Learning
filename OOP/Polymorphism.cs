using System;

class Employee
{
    public virtual void CalculateBonus()
    {
        Console.WriteLine("Standard Bonus");
    }
}

class Developer : Employee
{
    public override void CalculateBonus()
    {
        Console.WriteLine("15% Bonus");
    }
}

class Manager : Employee
{
    public override void CalculateBonus()
    {
        Console.WriteLine("25% Bonus");
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Developer();
        Employee emp2 = new Manager();

        emp1.CalculateBonus();
        emp2.CalculateBonus();
    }
}