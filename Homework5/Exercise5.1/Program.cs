using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int [7];

            for (int i = 0; i < vector.Length; i++) {
                Console.WriteLine("Введите число:");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            float mean = vector.Sum() / (float)vector.Length;
            Console.WriteLine("Среднее арифметическое - {0:f2}", mean);
            Console.ReadKey();

        }
    }
}
