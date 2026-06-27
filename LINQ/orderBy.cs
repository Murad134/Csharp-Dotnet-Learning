using System;
using System.Linq;
namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 5, 3, 8, 1, 4 };
            var result = numbers.OrderBy(n => n);
            Console.WriteLine("Numbers in ascending order:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}