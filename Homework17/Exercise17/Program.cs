using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account<string> account1 = new Account<string>();
            account1.Input();
            Console.WriteLine(account1.GetInfo());
            Account<int> account2 = new Account<int>();
            account2.Input();
            Console.WriteLine(account2.GetInfo());
            Console.ReadKey();

        }
    }

    class Account<T>
    {
        public T Id { get; set; }
        public double Ammount { get; set; }
        public string Name { get; set; }

        public void Input() {
            Console.Write("Введите номер счета: ");
            Id = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.Write("Введите ФИО владельца счета: ");
            Name = Console.ReadLine();
            Console.Write("Введите сумму на счету: ");
            Ammount = Convert.ToDouble(Console.ReadLine());
        }

        public string GetInfo()
        {
            return $"{Id} {Name} {Ammount}";
        }

    }
}
