using System;
namespace MyAplication
{
    class multiplicationTable
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication Table of : " + num);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i));
            }
        }
    }
}