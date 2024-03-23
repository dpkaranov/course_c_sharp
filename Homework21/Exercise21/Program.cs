using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exercise21
{
    internal class Program
    {
        int n = 10;
        public static int[,] garden = new int[5, 5] { 
            { 5, 12, 3, 17, 1 }, 
            { 11, 1, 4, 6, 1 }, 
            { 1, 10, 12, 6, 5 }, 
            { 5, 3, 4, 1, 1 }, 
            { 2, 1, 1, 5, 0 }};
        static void Main(string[] args)
        {
            ThreadStart gard1 = Gardener1;
            Thread first = new Thread(gard1);
            first.Start();
            Gardener2();
            Console.ReadKey();
        }

        static void Gardener1() {
            int schet = 0;
            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for (int j = 0; j < garden.GetLength(1); j++)
                {
                    if (garden[i,j] >= 0)
                    {
                        int delay = garden[i,j];
                        garden[i, j] = -1;
                        schet++;
                        Thread.Sleep(delay);
                    }
                }
            }
            Console.WriteLine($"Садовник 1 успел обработать {schet} участков");
        }

        static void Gardener2()
        {
            int schet = 0;
            for (int j = garden.GetLength(1) - 1; j >= 0; j--)
            {
                for (int i = garden.GetLength(0) - 1 ; i >= 0; i--)
                {
                    if (garden[i, j] >= 0)
                    {
                        int delay = garden[i, j];
                        garden[i, j] = -2;
                        schet++;
                        Thread.Sleep(delay);
                    }
                }
            }
            Console.WriteLine($"Садовник 2 успел обработать {schet} участков");
        }
    }
}
