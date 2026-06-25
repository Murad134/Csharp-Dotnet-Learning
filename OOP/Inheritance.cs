using System;
class Employee
{
    public string Name;
    public int Id;

    public void Login()
    {
        Console.WriteLine($"{Name} Logged In");
    }
}

class Developer : Employee
{
    public void WriteCode()
    {
        Console.WriteLine("Writing Code...");
    }
}

class Manager : Employee
{
    public void ConductMeeting()
    {
        Console.WriteLine("Meeting Started");
    }
}

class Program
{
    static void Main()
    {
        Developer dev = new Developer();

        dev.Name = "Murad";
        dev.Id = 101;

        dev.Login();
        dev.WriteCode();
    }
}