using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                double firstNumber = ReadDouble("Введите первое число: ");
                double secondNumber = ReadDouble("Введите второе число: ");
                string operation = ReadOperation();

                try
                {
                    double result = Calculate(firstNumber, secondNumber, operation);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }

                Console.WriteLine("Хотите выполнить ещё одну операцию? (y/n)");
                if (Console.ReadLine()?.ToLower() != "y")
                    break;

                Console.WriteLine();
            }
        }

        static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (double.TryParse(Console.ReadLine(), out double value))
                    return value;

                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }

        static string ReadOperation()
        {
            while (true)
            {
                Console.Write("Введите операцию (+, -, *, /): ");
                string operation = Console.ReadLine();

                if (operation == "+" || operation == "-" ||
                    operation == "*" || operation == "/")
                {
                    return operation;
                }

                Console.WriteLine("Неизвестная операция.");
            }
        }

        static double Calculate(double a, double b, string operation)
        {
            return operation switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => b != 0
                    ? a / b
                    : throw new DivideByZeroException("Деление на ноль запрещено"),
                _ => throw new InvalidOperationException("Недопустимая операция")
            };
        }
    }
}
