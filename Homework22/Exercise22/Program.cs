using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Func<object, int[]> func1 = new Func<object, int[]>(CreateArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);
            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(GetMax);
            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(SumArray);
            
            Task<int> task2 = task1.ContinueWith<int>(func2);
            Task<int> task3 = task1.ContinueWith<int>(func3);
            Action<Task<int>> action1 = new Action<Task<int>>(PrintSum);
            Action<Task<int>> action2 = new Action<Task<int>>(PrintMax);
            Task task4 = task2.ContinueWith(action1);
            Task task5 = task3.ContinueWith(action2);
            task1.Start();
            Console.ReadKey();
            
        }

        static int[] CreateArray(object o)
        {
            int n = (int)o;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 100);
            }
            return array;
        }

        static int SumArray(Task<int[]> task)
        {
            int[] array = task.Result;
            int summa = array.Sum();
            return summa;
        }

        static int GetMax(Task<int[]> task)
        {
            int[] array = task.Result;
            int max = array.Max();
            return max;
        }

        static void PrintMax(Task<int> task)
        {
            int max = task.Result;
            Console.WriteLine($"Максимальное значение - {max}");
        }

        static void PrintSum(Task<int> task)
        {
            int sum = task.Result;
            Console.WriteLine($"Сумма - {sum}");
        }
    }
}
