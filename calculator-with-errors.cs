using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            string operation = "";

            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите операцию (+, -, *, /):");
            operation = Console.ReadLine();

            double result = 0;

            if (operation == "+")
            {
                result = a + b;
            }
            else if (operation == "-")
            {
                result = a - b;
            }
            else if (operation == "*")
            {
                result = a * b;
            }
            else if (operation == "/")
            {
                if (b != 0)
                {
                    result = a / b;
                }
                else
                {
                    Console.WriteLine("Деление на ноль!");
                    result = 0;
                }
            }
            else
            {
                Console.WriteLine("Неизвестная операция");
            }

            Console.WriteLine("Результат: " + result);
            Console.ReadLine();
        }
    }
}
