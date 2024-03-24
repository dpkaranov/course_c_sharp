using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "./ExampleDir";
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string file in files) {
                Console.WriteLine(file);
            }
            string txt_path = "ExampleDir/test.txt";
            Random rand = new Random();
            using(StreamWriter sw = new StreamWriter(txt_path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    int rand_int = rand.Next(0, 100);
                    sw.WriteLine(rand_int);
                }
            }
            int summa = 0;
            using(StreamReader sr = new StreamReader(txt_path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int line = Convert.ToInt32(sr.ReadLine());
                    summa += line;
                }
            }
            Console.WriteLine("Сумма всех случайных чисел равна {0}", summa);
            Console.ReadKey();
        }
    }
}
