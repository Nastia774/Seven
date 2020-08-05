using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._2
{
    class Program
    {
        static int Add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
            return a + b;
        }
        static int Sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
            return a - b;
        }
        static int Mul(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a * b}");
            return a * b;
        }
        static double Div(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"{a} / {b} = {a / b}");
                return a / b;
            }
            Console.WriteLine("Вы пытаетесь поделить на ноль");
            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число : ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число : ");
            int value2 = int.Parse(Console.ReadLine());

            Console.Write("Введите операцию +, /, -, * : ");
            char sym = char.Parse(Console.ReadLine());

            switch (sym)
            {
                case '+':
                    {
                        Add(value1, value2);
                        break;
                    }
                case '-':
                    {
                        Sub(value1, value2);
                        break;
                    }
                case '*':
                    {
                        Mul(value1, value2);
                        break;
                    }
                case '/':
                    {
                        Div(value1, value2);
                        break;
                    }
                default:
                    Console.WriteLine("Вы ввели несуществующую операцию");
                    break;
            }
            Console.ReadKey();
        }
    }
}
