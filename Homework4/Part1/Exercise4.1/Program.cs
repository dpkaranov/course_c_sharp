using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа итеративно выводит слагаемые суммы квадрата N");
            Console.WriteLine("Ввести целое число N > 0:");
            int N = Convert.ToInt32(Console.ReadLine());
            int N2 = 0;
            for (int i = 1; i < N + 1; i++)
            {
                N2 += (2 * i - 1);
                Console.WriteLine(N2);
            }
            Console.WriteLine("Число {0} в квадрате равно {1}", N, N2);
            Console.ReadKey();  
        }
    }
}
