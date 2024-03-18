using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметры угла:");
            Console.Write("Градусы: ");
            double gradus = Convert.ToDouble(Console.ReadLine());
            Console.Write("Минуты: ");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.Write("Секунды: ");
            double sec = Convert.ToDouble(Console.ReadLine());
            Angle angle = new Angle();
            angle.Gradus = gradus;
            angle.Min = min;
            angle.Sec = sec;
            double radians = angle.ToRadians();
            Console.WriteLine("Угол равен {0:f2} радиан", radians);
            Console.ReadKey();
        }
    }

    class Angle
    {
        public double gradus, min, sec;

        public double Gradus
        {
            set
            {
                if (value > 360 || value < 0)
                {
                    Console.WriteLine("Градусы должны быть в пределах от 0 до 360");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    {
                        gradus = value;
                    }
                }

            }
            get { return gradus; }
        }

        public double Min
        {
            set {
                if (value > 60 ||  value < 0)
                {
                    Console.WriteLine("Минуты должны быть в пределах от 0 до 60");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    {
                        min = value;
                    }
                }
        
            }
            get { return min; }
        }

        public double Sec
        {
            set
            {
                if (value > 60 || value < 0)
                {
                    Console.WriteLine("Секунды должны быть в пределах от 0 до 60");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    {
                        sec = value;
                    }
                }

            }
            get { return sec; }
        }

        public double ToRadians()
        {
            double gradus = this.gradus + (this.min * 0.0167) + (this.sec * 0.000277778);
            return gradus * Math.PI / 180.0;
        }
    }
}
