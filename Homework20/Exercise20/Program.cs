using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    internal class Program
    {
        delegate double RoundDelegate(double r);
        static void Main(string[] args)
        {
            RoundDelegate RDeleg = LengthRound;
            RDeleg += SquareRound;
            RDeleg += VolumeRound;
            Console.Write("Введите радиус окружности: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double result = RDeleg(radius);
            Console.ReadKey();

        }

        static double LengthRound(double r)
        {
            double length = 2 * Math.PI * r;
            Console.WriteLine($"Длина - {length}");
            return length;
        }
        static double SquareRound(double r)
        {
            double square = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Площадь - {square}");
            return square;
        }
        static double VolumeRound(double r) {

            double volume = 4/3 * Math.PI* Math.Pow(r, 3);
            Console.WriteLine($"Объем - {volume}");
            return volume;
        }
    }
    
}
