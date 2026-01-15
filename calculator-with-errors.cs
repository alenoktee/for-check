using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Ошибка ввода числа");
                return;
            }

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Ошибка ввода числа");
                return;
            }

            Console.Write("Введите операцию (+, -, *, /): ");
            string operation = Console.ReadLine();

            double result;

            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно");
                        return;
                    }
                    result = a / b;
                    break;

                default:
                    Console.WriteLine("Неизвестная операция");
                    return;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
