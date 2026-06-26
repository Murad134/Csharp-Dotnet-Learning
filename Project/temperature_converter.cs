using System;
namespace MyAplication
{
    class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter Started");
            Console.WriteLine("Choose 1. Celsius to Fahrenheit");
            Console.WriteLine("Choose 2. Fahrenheit to Celsius");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter temperature in Celsius: ");
                    double celsius =Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
                    break;
                case 2:
                    Console.WriteLine("Enter temperature in Fahrenheit: ");
                    double fahrenheit2 = Convert.ToDouble(Console.ReadLine());
                    double celsius2 = (fahrenheit2 - 32) * 5 / 9;
                    Console.WriteLine("Temperature in Celsius: " + celsius2);
                    break;
            }
        }
    }
}