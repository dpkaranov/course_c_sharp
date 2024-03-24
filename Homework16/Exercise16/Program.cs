using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Exercise16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            int NUM = 0;
            int doNext = 0;
            Console.WriteLine("Выберите режим работы программы:");
            Console.WriteLine("\t1 - создать json файл с продуктами");
            Console.WriteLine("\t2 - открыть и прочитать json файл с продуктами");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Допустимо только целочисленное значение!");
                Environment.Exit(1);
            }
            
            Product[] products = new Product[5];
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Программа создает json-объект и сериализует его в файл (5)");
                    while (NUM < 5) {
                        try
                        {
                            Console.Write("Введите код продукта: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Введите название продукта: ");
                            string name = Console.ReadLine();
                            Console.Write("Введите цену продукта: ");
                            int price = Convert.ToInt32(Console.ReadLine());
                            Product product = new Product() { Id = id, Name = name, Price = price };
                            products[NUM] = product;
                            Console.WriteLine("Продолжить? (1 - да)");
                            doNext = Convert.ToInt32(Console.ReadLine());
                        } catch
                        {
                            Console.WriteLine("Введен недопустимый тип данных!");
                        }
                        
                        if (doNext != 1)
                        {
                            break;
                        }
                        NUM++;
                    }
                    if (NUM >= 5)
                    {
                        Console.WriteLine("Достигнут предел записей!");
                    }
                    JsonSerializerOptions options = new JsonSerializerOptions()
                    {
                        Encoder=JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                        WriteIndented = true
                    };
                    string jsonSerilise = JsonSerializer.Serialize(products, options);
                    using(StreamWriter sw = new StreamWriter("Products.json"))
                    {
                        sw.WriteLine(jsonSerilise);
                    }
                    break;
                case 2:
                    Console.WriteLine("Программа десериализует файл Products.json");
                    string productsFromJson = String.Empty;
                    using(StreamReader sr = new StreamReader("Products.json"))
                    {
                        productsFromJson = sr.ReadToEnd();
                    }
                    Product[] products_ = JsonSerializer.Deserialize<Product[]>(productsFromJson);
                    int mostExpensive = 0;
                    for(int i = 1;i < products_.Length; i++)
                    {
                        if (products_[i].Price > products_[mostExpensive].Price)
                        {
                            mostExpensive = i;
                        }
                    }
                    Console.WriteLine($"Наиболее дорогой товар:\nНазвание - {products_[mostExpensive].Name}\nЦена - {products_[mostExpensive].Price}");
                    break;
                default:
                    Console.WriteLine("Введено недопустимое значение!");
                    break; 
            }
            Console.ReadKey();
            
        }
    }
}
