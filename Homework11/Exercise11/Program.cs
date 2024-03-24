using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа решает линейное уравнение вида 0 = kx + b");
            double x;
            Console.Write("Введите k: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Linear linear = new Linear(k, b);
            x = linear.Root();
            Console.WriteLine($"X равен {x}");
            Console.ReadKey();
        }
    }
}
