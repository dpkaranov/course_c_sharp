using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    static public class Round
    {
        static public double Length(double radius)
        {
            return (radius * 2) * Math.PI;
        }

        static public double Square(double radius)
        {
            return Math.Pow(radius * 2, 2) / (4 * Math.PI);
        }

        static public double Euclidian(double xCenter, double yCenter, double x, double y)
        {
            return Math.Sqrt(Math.Pow(x - xCenter, 2) + Math.Pow(y - yCenter, 2));
        }

        static public bool InRound(double radius, double x0, double y0, double xt, double yt)
        {
            double diff = Euclidian(x0, y0, xt, yt);
            if (diff <= radius)
            {
                return true;
            }
            return false;
        }
    }
}
