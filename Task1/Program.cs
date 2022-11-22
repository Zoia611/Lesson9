using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветсвует калькулятор!");
                Console.WriteLine("Введите первое число");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите операцию ( + - * / )");
                string[] array = { "+", "-", "*", "/" };
                string s = Console.ReadLine();

                try
                {
                    if (!array.Contains(s))
                    {
                        throw new Exception("Не верная операция");
                    }
                    if (s == "*")
                    {
                        Console.WriteLine($"Ответ: {x} * {y} = {x * y}");
                    }
                    else if (s == "/")
                    {
                        Console.WriteLine($"Ответ: {x} / {y} = {x / y}");
                    }
                    else if (s == "+")
                    {
                        Console.WriteLine($"Ответ: {x} + {y} = {x + y}");
                    }
                    else
                    {
                        Console.WriteLine($"Ответ: {x} - {y} = {x - y}");
                    }
                }
                catch (DivideByZeroException ex) when (s == "/" && y == 0)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
