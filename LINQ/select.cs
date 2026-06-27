using System;
using System.Linq;
namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            int[] numbers = {1, 2, 3, 4, 5};
            var result =numbers.Select(n=> n*2);
            Console.WriteLine("Doubled numbers in the array:");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}