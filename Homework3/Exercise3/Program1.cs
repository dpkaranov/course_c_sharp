using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3, x4, y4;
            x4 = 0;
            y4 = 0;
            Console.WriteLine("Программа позволяет определить координаты вершины прямоугольника при указании 3 вершин");
            Console.WriteLine("Введите x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x3: ");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y3: ");
            y3 = Convert.ToInt32(Console.ReadLine());
            if (x1 == x3)
            {
                x4 = x2;
            } else if (x1 == x2)
            {
                x4 = x3;
            } else if (x2 == x3)
            {
                x4 = x1;
            } else
            {
                Console.WriteLine("Стороны прямоугольника не параллельны координатным осям");
                Console.ReadKey();
                Environment.Exit(1);
            }
            if (y1 == y3)
            {
                y4 = y2;
            }
            else if (y1 == y2)
            {
                y4 = y3;
            }
            else if (y2 == y3)
            {
                y4 = y1;
            }
            else
            {
                Console.WriteLine("Стороны прямоугольника не параллельны координатным осям");
                Console.ReadKey();
                Environment.Exit(1);
            }
            Console.WriteLine("Координаты четвертой вершины - ({0},{1})", x4, y4);
            Console.ReadKey();
            Environment.Exit(1);
        }
    }
}
