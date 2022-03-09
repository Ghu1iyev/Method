using System;

namespace Ap204
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operator();

        }

        #region task2
        public static void Operator()
        {
            Console.Write("Enter the num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an option");
            Console.WriteLine("+ : Add");
            Console.WriteLine("- : Subtract");
            Console.WriteLine("* : Multiply");
            Console.WriteLine("/ : Divide");
            int result = 0;
            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"your result: {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"your result: {num1} - {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"your result: {num1} / {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"your result: {num1} * {num2} = " + result);
                    break;
            }
            Console.WriteLine();
        }
        #endregion
    }
}
