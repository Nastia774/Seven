using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7.add
{
    class Program
    {
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine($"( {a} + {b} + {c} ) / 3 = {(a+b+c)/3}");
        }
        static void Main(string[] args)
        {
            Console.Write("Введите первое число : ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число : ");
            int value2 = int.Parse(Console.ReadLine());
            
            Console.Write("Введите третье число : ");
            int value3 = int.Parse(Console.ReadLine());

            Calculate(value1, value2, value3);

            Console.ReadKey();
        }
    }
}
