using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Method(n);
            Console.ReadKey();
        }

        public static async void Method(int n)
        {
            await Task.Run(() => ComputeFactorial(n));
        }

        public static void ComputeFactorial(int n)
        {
            int f = Factorial(n);
            Console.WriteLine($"!{n} = {f}");
        }

        public static int Factorial(int num)
        {
            if (num == 0)
                return 1;
            return num * Factorial(num - 1);
        }
    }
}
