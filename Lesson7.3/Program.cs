using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._3
{
    class Program
    {
        static void Conv (decimal sum, decimal curs)
        {
            Console.WriteLine($"Вы ввели сумму {sum} и хотите поменять по такому курсу {curs} у вас будет {sum/curs} после конвертирования");
        }
        static void Main(string[] args)
        { 
            Console.Write("Введите сумму которую хотите конвертировать : ");
            decimal sum = Decimal.Parse(Console.ReadLine());

            Console.Write("Введите курс по которому хотите конвертировать : ");
            decimal curs = Decimal.Parse(Console.ReadLine());

            Conv(sum, curs);

            Console.ReadKey();
        }
    }
}
