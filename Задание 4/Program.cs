using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N2 = 0;
            int N = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}", i, N2 = N2 + (2 * i - 1));
            }
            Console.ReadKey();
        }
    }
}
