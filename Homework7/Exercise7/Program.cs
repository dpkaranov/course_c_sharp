using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа определяет площадь какого треугольника больше и вычисляет площадь и объем куба");
            Console.WriteLine("Введите 1 для сравнения площадей треугольников");
            Console.WriteLine("Введите 2 для вычисления площади и объема куба");
            int answer = Convert.ToInt32(Console.ReadLine());
            switch (answer)
            {
                case 1: 
                    Console.WriteLine("Для сравнения площадей последовательно введите длины сторон");
                    double square1, square2;
                    double[,] triangle = new double[3,3];
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("Стороны треугольника {0}", i+1);
                        Console.WriteLine("Введите a");
                        triangle[i, 0] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите b");
                        triangle[i, 1] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите c");
                        triangle[i, 2] = Convert.ToDouble(Console.ReadLine());
                    }
                    (square1, square2) = GeronSquare(triangle);
                    Console.WriteLine("Площадь первого треугольника равна {0}", square1);
                    Console.WriteLine("Площадь второго треугольника равна {0}", square2);
                    if (square1 > square2) {
                        Console.WriteLine("Первый больше");
                    } else if (square1 == square2) {
                        Console.WriteLine("Площади равны");
                    } else
                    {
                        Console.WriteLine("Второй больше");
                    }
                    break;
                case 2:
                    double square, volume;
                    Console.WriteLine("Введите длину стороны куба");
                    double side = Convert.ToDouble(Console.ReadLine());
                    (square, volume) = CubeSquareAndVolume(side);
                    Console.WriteLine("Площадь куба равна {0}, а его объем равен {1}", square, volume);
                    break;
                default: 
                    Console.WriteLine("Недопустимое значение");
                    break;
            }
            Console.ReadKey();
        }

        static (double, double) GeronSquare(double [,] triangle)
        {
            double pperimetr1 = (triangle[0, 0] + triangle[0, 1] + triangle[0, 2]) / 2.0;
            double pperimetr2 = (triangle[1, 0] + triangle[1, 1] + triangle[1, 2]) / 2.0;
            Console.WriteLine("{0}, {1}", pperimetr1, pperimetr2);
            double square1 = Math.Sqrt(pperimetr1 * (pperimetr1 - triangle[0, 0]) * (pperimetr1 - triangle[0, 1]) * (pperimetr1 - triangle[0, 2]));
            double square2 = Math.Sqrt(pperimetr2 * (pperimetr2 - triangle[1, 0]) * (pperimetr2 - triangle[1, 1]) * (pperimetr2 - triangle[1, 2]));
            return (square1, square2);
        }

        static (double, double) CubeSquareAndVolume(double side)
        {
            double square = 6 * Math.Pow(side, 2);
            double volume = Math.Pow(side, 3);
            return (square, volume);
        }
    }
}
