using System;
using System.Linq;
namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            int[] numbers = {2,3,4,5,6,7,8,9,10};
            var result =numbers.Where(n=> n%2==0);
            Console.WriteLine("Even numbers in the array:");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}