using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа демонстрирует различие между арифметической и геометрической прогрессиями");
            Console.Write("Введите стартовое число: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите шаг: ");
            int step = Convert.ToInt32(Console.ReadLine());
            ArithProgression aprogression = new ArithProgression(start, step);
            GeomProgression gprogression = new GeomProgression(start, step);
            Console.WriteLine("Первые 10 чисел арифметической прогрессии");
            Console.WriteLine($"{start}");
            for (int i = 0; i < 9; i++)
            {
                int num = aprogression.GetNext();
                Console.WriteLine($"{num}");
            }
            Console.WriteLine("Первые 10 чисел геометрической прогрессии");
            Console.WriteLine($"{start}");
            for (int i = 0; i < 9; i++)
            {
                int num = gprogression.GetNext();
                Console.WriteLine($"{num}");
            }
            Console.WriteLine("");
            Console.WriteLine("Сборс до начальных значений");
            Console.WriteLine("");
            aprogression.Reset();
            gprogression.Reset();
            Console.WriteLine("Первые 10 чисел арифметической прогрессии");
            Console.WriteLine($"{start}");
            for (int i = 0; i < 9; i++)
            {
                int num = aprogression.GetNext();
                Console.WriteLine($"{num}");
            }
            Console.WriteLine("Первые 10 чисел геометрической прогрессии");
            Console.WriteLine($"{start}");
            for (int i = 0; i < 9; i++)
            {
                int num = gprogression.GetNext();
                Console.WriteLine($"{num}");
            }
            Console.ReadKey();
        }
    }
}
