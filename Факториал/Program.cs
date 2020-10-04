using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Факториал
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, для нахождения факториала: ");
            int f = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            
            
            for (int i=2; i<=f; i++)
            {

                result *= i;

            }
            Console.WriteLine("Результат равен: " + result);
        }
    }
}
