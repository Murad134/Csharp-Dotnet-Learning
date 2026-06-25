using System;
namespace MyAplication
{
    class Test
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.WriteLine("Enter an operator (+, -, *, /): ");
            op = Console.ReadLine()[0];

            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
        }
    }
}