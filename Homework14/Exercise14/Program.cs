using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка");
            cat.ShowInfo();
            Dog dog = new Dog("Мухтар");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
