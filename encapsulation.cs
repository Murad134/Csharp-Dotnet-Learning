using System;
class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Murad";
        Console.WriteLine(p.Name);
    }
}
