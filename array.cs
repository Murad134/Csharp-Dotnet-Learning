using System;
namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[10];
            int sum = 0, smallest, largest;
            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int num in numbers)
            {
                sum += num;
            }
            double avg = (double)sum / numbers.Length;
            smallest = Array.Min(numbers);
            largest = Array.Max(numbers);
            int searchNum;
            Console.Write("Enter a number to search: ");
            searchNum = Convert.ToInt32(Console.ReadLine());
            int index = Array.IndexOf(numbers, searchNum);
            if (index != -1)
            {
                Console.WriteLine("Number found at index: " + index);
            }
            else
            {
                Console.WriteLine("Number not found in the array.");
            }
            Console.WriteLine("Sum of numbers: " + sum);
            Console.WriteLine("Average of numbers: " + avg);
            Console.WriteLine("Smallest number: " + smallest);
            Console.WriteLine("Largest number: " + largest);
        }
    }
}