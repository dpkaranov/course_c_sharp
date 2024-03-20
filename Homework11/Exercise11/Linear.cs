using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    struct Linear
    {
        double k , b, x;

        public Linear(double k, double b)
        {
            this.k = k;
            this.b = b;
            this.x = 0;
        }

        public double Root()
        {
            x = -(b) / k;
            return x;
        }
    }
}
