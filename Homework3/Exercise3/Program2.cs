using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            string first_slog = "";
            string second_slog = "";
            string third_slog = "";
            Console.WriteLine("Программа возвращает строковое описание возраста в диапазоне от 20 до 69");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 20 || age > 69) {
                Console.WriteLine("Введен недопустимы возраст. Возраст должен быть в диапазоне от 20 до 69 лет");
            }
            int first = age / 10;
            int second = age % 10;
            
            switch (first)
            {
                case 2:
                    first_slog = "двадцать";
                    break;
                case 3:
                    first_slog = "тридцать";
                    break;
                case 4:
                    first_slog = "сорок";
                    break;
                case 5:
                    first_slog = "пятьдесят";
                    break;
                case 6:
                    first_slog = "шестьдесят";
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;

            }
            switch (second)
            {
                case 0:
                    second_slog = "";
                    break;
                case 1:
                    second_slog = "один";
                    break;
                case 2:
                    second_slog = "два";
                    break;
                case 3:
                    second_slog = "три";
                    break;
                case 4:
                    second_slog = "четыре";
                    break;
                case 5:
                    second_slog = "пять";
                    break;
                case 6:
                    second_slog = "шесть";
                    break;
                case 7:
                    second_slog = "семь";
                    break;
                case 8:
                    second_slog = "восемь";
                    break;
                case 9:
                    second_slog = "девять";
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }
            switch (second)
            {
                case 1:
                    third_slog = "год";
                    break;
                case 2: case 3: case 4:
                    third_slog = "года";
                    break;
                case 0: case 5: case 6: case 7: case 8: case 9:
                    third_slog = "лет";
                    break;
            }
            Console.WriteLine("Возраст - {0} {1} {2}", first_slog, second_slog, third_slog);
            Console.ReadKey();
        }
    }
}
