using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа определяет является ли предложение палиндромом или нет");
            Console.WriteLine("Введите предложение");
            string sentence = Console.ReadLine();
            sentence = sentence.Trim().Replace(" ", "").ToLower();
            char[] char_array = sentence.ToCharArray();
            Array.Reverse(char_array);
            string reversed = new string(char_array);
            if (sentence == reversed)
            {
                Console.WriteLine("Это палиндром");
            } else
            {
                Console.WriteLine("Это предложение не палиндром");
            }
            Console.ReadKey();
        }
    }
}
