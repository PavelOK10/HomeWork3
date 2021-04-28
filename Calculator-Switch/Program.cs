using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a, c;

                try
                {
                    Console.WriteLine("Введите первое число");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    c = Convert.ToDouble(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Неправильный ввод данных. Попробуйте еще раз");
                    Console.ReadLine();
                    continue;
                }
                    Console.WriteLine("Выберите знак операции '+', '-', '*', '/' ");
                    string b = Console.ReadLine();

                switch (b)
                {
                    case "+":
                        Console.WriteLine("Операция сложения равна: " + (a + c));
                        break;

                    case "-":
                        Console.WriteLine("Операция вычитания равна: " + (a - c));
                        break;

                    case "*":
                        Console.WriteLine("Операция умножения равна: " + (a * c));
                        break;

                    case "/":
                        if (c == 0)
                            Console.WriteLine("Делить на ноль нельзя");
                        else
                            Console.WriteLine("Операция деления равна: " + (a / c));
                        break;

                    default:
                        Console.WriteLine("Неизвестное действие");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
