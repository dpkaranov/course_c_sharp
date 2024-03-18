using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            int answer = 0;
            int X, Y;
            X = 0;
            Y = 0;
            int N = 0;
            try
            {
                Console.Write("Введите целое число. X=");
                X = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                Y = Convert.ToInt32(Console.ReadLine());
            } catch (Exception ex)
            {
                Console.WriteLine("Ошибка! Входная строка имеет неверный формат.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            try
            {
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("\t1 - сложение");
                Console.WriteLine("\t2 - вычитание");
                Console.WriteLine("\t3 - произведение");
                Console.WriteLine("\t4 - частное");
                Console.Write("Ваш выбор: ");
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! Допустимо только целочисленное значение");
                Console.ReadKey();
                Environment.Exit(0);
            }
            switch (N)
            {
                case 1:
                    answer = X + Y;
                    break;
                case 2:
                    answer = X - Y;
                    break;
                case 3:
                    answer = X * Y;
                    break;
                case 4:
                    answer = X / Y;
                    break;
                default:
                    Console.WriteLine("Нет операции с указанным номером");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

            }
            Console.WriteLine("Результат = {0}", answer);
            Console.ReadKey();
        }
    }
}
