using System;
// class Car
// {
//     private string model = "BMW";
//     static void Main(string[] args)
//     {
//         Car myobj = new Car();
//         Console.WriteLine(myobj.model);
//     }
// }

class Bike
{
    public string model = "Yamaha";
}

class Program
{
    static void Main(string[] args)
    {
        Car fst = new Car();
        Console.WriteLine(fst.model);
    }
}