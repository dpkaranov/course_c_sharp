using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int doCoords = 3;
            Console.WriteLine("Программа вычисляет длину окружности и её площадь по радиусу. Опционально можно определить принадлежат ли координаты какой-либо точки кругу");
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double length = Round.Length(radius);
            double square = Round.Square(radius);
            Console.WriteLine($"Длина окружности равна {length}");
            Console.WriteLine($"Площадь равна {square}");
            Console.Write("Хотите определить принадлежность координат заданному кругу? (1 - да, 0 - нет) ");
            try
            {
                doCoords = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Валидно только целочисленное значение");
            }
            switch (doCoords)
            {
                case 1:
                    Console.Write("Введите x центра: ");
                    double center_x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите y центра: ");
                    double center_y = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите x : ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите y: ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    if (Round.InRound(radius, center_x, center_y, x, y))
                    {
                        Console.WriteLine($"Точка ({x},{y}) принадлежит кругу");
                    } else
                    {
                        Console.WriteLine($"Точка ({x},{y}) не принадлежит кругу");
                    }
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Неправильное значение! Допустимо только 0 или 1");
                    break;
            }
            Console.ReadLine();
        }
    }
}
