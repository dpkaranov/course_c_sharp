using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа определяет правильность расставления скобок");
            Console.WriteLine("Введите последовательность скобок");
            string scobka = Console.ReadLine();
            bool checker = CheckScobka(scobka);
            if (checker)
            {
                Console.WriteLine("Скобки расставлены правильно!");
            } else
            {
                Console.WriteLine("Скобки расставлены неправильно!");
            }
            Console.ReadKey();

        }

        public static bool CheckScobka(string scobka)
        {
            
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>()
            {
                {'(',')'},
                {'{','}'},
                {'[',']'}
            };
            foreach (char c in scobka)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(dict[c]);
                }
                if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
    }
}
