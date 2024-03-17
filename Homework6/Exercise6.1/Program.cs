using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа определяет самое длинное слово в предложении");
            Console.WriteLine("Введите предложение:");
            string sentence = Console.ReadLine();
            int length = 0;
            string most = "";
            string [] massiv = sentence.Split(' ');
            foreach (var str in massiv) {
                if (str.Length > length)
                {
                    length = str.Length;
                    most = str;
                }
            }
            Console.WriteLine("Самое длинное слово в предложении - {0}. Его длина - {1}", most, length);
            Console.ReadKey();
        }
    }
}
