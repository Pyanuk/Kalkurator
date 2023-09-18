using System;

class Calculator
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("Выберите операцию (введите номер):");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. Найти 1% от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выйти");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Power();
                    break;
                case 6:
                    SquareRoot();
                    break;
                case 7:
                    Percentage();
                    break;
                case 8:
                    Factorial();
                    break;
                case 9:
                    Console.WriteLine("Выход из программы...");
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции. Попробуйте снова.");
                    break;
            }

            Console.WriteLine();
        }
        while (choice != 9);
    }

    static void Addition()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());
        double result = num1 + num2;
        Console.WriteLine($"Результат: {result}");
    }

    static void Subtraction()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());
        double result = num1 - num2;
        Console.WriteLine($"Результат: {result}");
    }

    static void Multiplication()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());
        double result = num1 * num2;
        Console.WriteLine($"Результат: {result}");
    }

    static void Division()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
        }
        else
        {
            double result = num1 / num2;
            Console.WriteLine($"Результат: {result}");
        }
    }

    static void Power()
    {
        Console.WriteLine("Введите число:");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите степень:");
        int power = int.Parse(Console.ReadLine());
        double result = Math.Pow(num, power);
        Console.WriteLine($"Результат: {result}");
    }

    static void SquareRoot()
    {
        Console.WriteLine("Введите число:");
        double num = double.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Ошибка: невозможно вычислить квадратный корень из отрицательного числа.");
        }
        else
        {
            double result = Math.Sqrt(num);
            Console.WriteLine($"Результат: {result}");
        }
    }

    static void Percentage()
    {
        Console.WriteLine("Введите число:");
        double num = double.Parse(Console.ReadLine());
        double result = num * 0.01;
        Console.WriteLine($"Результат: {result}");
    }

    static void Factorial()
    {
        Console.WriteLine("Введите число:");
        int num = int.Parse(Console.ReadLine());
        int result = 1;

        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }

        Console.WriteLine($"Результат: {result}");
    }
}