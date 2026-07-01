using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = {1,2,2,3,4,4,5};

        var result = numbers.Distinct();

        foreach(var item in result)
        {
            Console.WriteLine(item);
        }
    }
}