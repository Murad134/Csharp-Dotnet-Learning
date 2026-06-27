using System;
using System.Linq;
namespace MyAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Max());
        }
    }
}