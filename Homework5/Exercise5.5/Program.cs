using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[N, N];
            int tmp_num = 1;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = tmp_num;
                    Console.Write("{0} ", matrix[i,j]);
                    tmp_num = (tmp_num == 1 ) ? 0 : 1;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
           
        }
    }
}
