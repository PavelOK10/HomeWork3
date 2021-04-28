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
                string b;

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
                    b = Console.ReadLine();

                if (b == "+")
                {
                    Console.WriteLine("Операция сложения равна: " + (a + c));
                }
                else if (b == "-")
                {
                    Console.WriteLine("Операция вычитания равна: " + (a - c));
                }

                else if (b == "*")
                {
                    Console.WriteLine("Операция умножения равна: " + (a * c));
                }
                else if (b == "/")
                {
                    if (c == 0)
                        Console.WriteLine("Делить на ноль нельзя");
                    else
                        Console.WriteLine("Операция деления равна: " + (a / c));

                    Console.ReadLine();
                }
            }
        }
    }
}
