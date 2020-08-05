using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._4
{
    class Program
    {
        static void CheckNumber(int num)
        {
            int n = 0;
            if (num >= 0)
            {
                Console.WriteLine("Положительное число");
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        n++;
                    }
                }
                if (n <= 2)
                {
                    Console.WriteLine("Простое число");
                }
            }
            else
            {
                Console.WriteLine("Отрицательное число");
                for (int i = num; i < 0; i++)
                {
                    if (num % i == 0)
                    {
                        n++;
                    }
                }
                if (n <= 2)
                {
                    Console.WriteLine("Простое число");
                }
            }
            Console.Write("Ваше число делиться на : ");
            for (int i = 0; i < 10; i++)
            {

                if (i == 2 || i == 3 || i == 5 || i == 6 || i == 9)
                {
                    if (num % i == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int num = int.Parse(Console.ReadLine());
            CheckNumber(num);

            Console.ReadKey();
        }
    }
}
