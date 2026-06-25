using System;
class Employee
{
    private string name;
    private double salary;
    public Employee(string name, double salary)
    {
        this.name = name;
        this.salary = salary;
    }
    // Read-only access
    public double GetSalary()
    {
        return salary;
    }
    // Controlled access
    public void IncreaseSalary(double amount)
    {
        if (amount > 0)
        {
            salary += amount;
        }
        else
        {
            Console.WriteLine("Increase amount must be positive.");
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Salary: {salary}");
    }
}
class Program
{
    static void Main()
    {
        Employee emp = new Employee("Murad", 30000);
        emp.DisplayInfo();
        emp.IncreaseSalary(5000);
        Console.WriteLine("\nAfter Increment:");
        emp.DisplayInfo();
    }
}