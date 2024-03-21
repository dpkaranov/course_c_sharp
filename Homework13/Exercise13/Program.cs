using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length, width, height;
            length = 0;
            width = 0;
            height = 0;
            int levels = 0;
            Console.WriteLine("Программа выводит в консоль информацию о здании");
            Console.Write("Введите адрес: ");
            string address = Console.ReadLine();
            try
            {
                Console.Write("Введите длину здания: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите ширину здания: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите высоту здания: ");
                height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите количество этажей: ");
                levels = Convert.ToInt32(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Неправильный тип данных. Введите число!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (levels > 0) {
                MultiBuilding building = new MultiBuilding(address, length, width, height, levels);
                building.Print();
                Console.ReadKey();
            } else
            {
                Building building = new Building(address, length, width, height);
                building.Print();
                Console.ReadKey();
            }
            
            Environment.Exit(0);
        }
    }
}
