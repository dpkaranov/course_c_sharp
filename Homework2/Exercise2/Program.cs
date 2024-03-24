using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise2
{
    internal class Program
    {
        static double getRoundRadius(double length)
        {
            double radius = length / (2 * Math.PI);
            return radius;
        }

        static double getRoundSquare(double radius)
        {
            double square = Math.Pow(radius, 2)  * Math.PI;
            return square;
        }

        static double getRectangleSquare(double x1, double x2, double y1, double y2)
        {
            double square = (y2 - y1) * (x2 - x1);
            return square;
        }

        static double getRectanglePerimetr(double x1, double x2, double y1, double y2)
        {
            double perimetr = 2 * ((y2 - y1) + (x2 - x1));
            return perimetr;
        }

        static (double, double, double) getTriangleSides(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double a = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            double b = Math.Sqrt((Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)));
            double c = Math.Sqrt((Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2)));
            return (a, b, c);
        }

        static double getTrianglePerimetr(double a, double b, double c)
        {
            return a + b + c;
        }

        static double getTriangleSquare(double a, double b, double c, double perimetr)
        {
            double semiperimetr = perimetr / 2;
            double square = Math.Sqrt(semiperimetr * (semiperimetr - a) * (semiperimetr - b) * (semiperimetr - c));
            return square;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите задачу:");
            Console.WriteLine("1 - найти радиус и площадь круга по длине окружности");
            Console.WriteLine("2 - найти периметр и площадь прямоугольника по координатам двух противоположных вершин");
            Console.WriteLine("3 - найти периметр и площадь треугольника по координатам вершин");
            Console.WriteLine("Номер задачи:");

            int numberExcercise = Convert.ToInt32(Console.ReadLine());

            if (numberExcercise == 1) {
                Console.WriteLine("Выбрана задача 1");

                double roundLength;
                Console.WriteLine("Введите длину окружности");
                double.TryParse(Console.ReadLine(), out roundLength);
                double radius = getRoundRadius(roundLength);
                double square = getRoundSquare(radius);
                Console.WriteLine("Радиус круга - {0}", radius);
                Console.WriteLine("Площадь круга - {0}", square);

            } else if (numberExcercise == 2) {
                Console.WriteLine("Выбрана задача 2");
                double x1,x2,y1,y2;
                Console.WriteLine("Введите x1");
                double.TryParse(Console.ReadLine(), out x1);
                Console.WriteLine("Введите y1");
                double.TryParse(Console.ReadLine(), out y1);
                Console.WriteLine("Введите x2");
                double.TryParse(Console.ReadLine(), out x2);
                Console.WriteLine("Введите y2");
                double.TryParse(Console.ReadLine(), out y2);

                double square = getRectangleSquare(x1,x2,y1,y2);
                double perimetr = getRectanglePerimetr(x1,x2,y1,y2);

                Console.WriteLine("Площадь прямоугольника - {0}", square);
                Console.WriteLine("Периметр прямоугольника - {0}", perimetr);

            } else if (numberExcercise == 3) {
                Console.WriteLine("Выбрана задача 3");
                double x1, x2, x3, y1, y2, y3, a, b, c, square, perimetr;
                Console.WriteLine("Введите x1");
                double.TryParse(Console.ReadLine(), out x1);
                Console.WriteLine("Введите y1");
                double.TryParse(Console.ReadLine(), out y1);
                Console.WriteLine("Введите x2");
                double.TryParse(Console.ReadLine(), out x2);
                Console.WriteLine("Введите y2");
                double.TryParse(Console.ReadLine(), out y2);
                Console.WriteLine("Введите x3");
                double.TryParse(Console.ReadLine(), out x3);
                Console.WriteLine("Введите y3");
                double.TryParse(Console.ReadLine(), out y3);
                (a, b, c) = getTriangleSides(x1,y1,x2,y2,x3,y3);
                perimetr = getTrianglePerimetr(a, b, c);
                square = getTriangleSquare(a, b, c, perimetr);
                Console.WriteLine("Периметр треугольника равен {0}", perimetr); 
                Console.WriteLine("Площадь треугольника равна {0}", square);

            } else {
                Console.WriteLine("Неверное значение. Допустимы только 1, 2, 3");

            }

            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }
    }
}
