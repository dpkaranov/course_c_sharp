using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer() { Id = "01234", Brand="Dell", Cpu="Intel", CpuFrequency=2000, MemoryVolume=8, DiskVolume=500, VideoVolume=2, Price=500, Amount=29},
                new Computer() { Id = "01454", Brand="Acer", Cpu="AMD", CpuFrequency=2200, MemoryVolume=16, DiskVolume=1000, VideoVolume=2, Price=700, Amount=11},
                new Computer() { Id = "01564", Brand="HP", Cpu="Intel", CpuFrequency=1800, MemoryVolume=16, DiskVolume=500, VideoVolume=2, Price=450, Amount=75},
                new Computer() { Id = "01894", Brand="Dell", Cpu="AMD", CpuFrequency=1100, MemoryVolume=4, DiskVolume=250, VideoVolume=0, Price=150, Amount=7},
                new Computer() { Id = "01374", Brand="Acer", Cpu="Intel", CpuFrequency=1500, MemoryVolume=8, DiskVolume=1000, VideoVolume=2, Price=500, Amount=121},
                new Computer() { Id = "01884", Brand="Dell", Cpu="AMD", CpuFrequency=1700, MemoryVolume=8, DiskVolume=500, VideoVolume=2, Price=500, Amount=5},
                new Computer() { Id = "01114", Brand="Acer", Cpu="AMD", CpuFrequency=2400, MemoryVolume=32, DiskVolume=1000, VideoVolume=6, Price=2300, Amount=67},
                new Computer() { Id = "01004", Brand="Dell", Cpu="AMD", CpuFrequency=1200, MemoryVolume=16, DiskVolume=500, VideoVolume=2, Price=400, Amount=8},
                new Computer() { Id = "01464", Brand="HP", Cpu="Intel", CpuFrequency=1200, MemoryVolume=16, DiskVolume=500, VideoVolume=4, Price=450, Amount=11},
                new Computer() { Id = "01224", Brand="HP", Cpu="AMD", CpuFrequency=2400, MemoryVolume=32, DiskVolume=1000, VideoVolume=8, Price=2500, Amount=34},
            };
            Console.Write("Введите процессор: ");
            string cpuBrand = Console.ReadLine();
            List<Computer> comps = (from comp in computers where comp.Cpu == cpuBrand select comp).ToList();

            foreach (Computer comp in comps)
            {
                Console.WriteLine($"{comp.Id} {comp.Brand} {comp.Cpu} {comp.CpuFrequency} {comp.MemoryVolume} {comp.DiskVolume} {comp.VideoVolume} {comp.Price} {comp.Amount}");
            }

            Console.Write("Введите объем оперативной памяти: ");
            int memory = Convert.ToInt32(Console.ReadLine());
            List<Computer> mcomps = (from comp in computers where comp.MemoryVolume >= memory select comp).ToList();

            foreach (Computer comp in mcomps)
            {
                Console.WriteLine($"{comp.Id} {comp.Brand} {comp.Cpu} {comp.CpuFrequency} {comp.MemoryVolume} {comp.DiskVolume} {comp.VideoVolume} {comp.Price} {comp.Amount}");
            }

            Console.WriteLine("Список компьютеров отсортированный по возрастанию цены");

            List<Computer> sortedComps = computers.OrderBy(comp => comp.Price).ToList();

            foreach(Computer comp in sortedComps)
            {
                Console.WriteLine($"{comp.Id} {comp.Brand} {comp.Cpu} {comp.CpuFrequency} {comp.MemoryVolume} {comp.DiskVolume} {comp.VideoVolume} {comp.Price} {comp.Amount}");
            }

            Console.WriteLine("Список компьютеров, сгруппированный по названию процессора");

            IEnumerable<IGrouping<string,Computer>> groupComps = computers.GroupBy(x => x.Cpu);

            foreach (IGrouping<string, Computer> gr in groupComps)
            {
                foreach (Computer comp in gr)
                {
                    Console.WriteLine($"{comp.Id} {comp.Brand} {comp.Cpu} {comp.CpuFrequency} {comp.MemoryVolume} {comp.DiskVolume} {comp.VideoVolume} {comp.Price} {comp.Amount}");
                }
            }
            Computer mostCheep = sortedComps[0];
            sortedComps.Reverse();
            Computer mostExpensive = sortedComps[0];
            Console.WriteLine($"Самый дорогой компьютер - {mostExpensive.Id} {mostExpensive.Brand} {mostExpensive.Cpu} {mostExpensive.CpuFrequency} {mostExpensive.MemoryVolume} {mostExpensive.DiskVolume} {mostExpensive.VideoVolume} {mostExpensive.Price} {mostExpensive.Amount}");
            Console.WriteLine($"Самый дешевый компьютер - {mostCheep.Id} {mostCheep.Brand} {mostCheep.Cpu} {mostCheep.CpuFrequency} {mostCheep.MemoryVolume} {mostCheep.DiskVolume} {mostCheep.VideoVolume} {mostCheep.Price} {mostCheep.Amount}");
            Console.WriteLine("Все компьютеры в количестве от 30 штук");
            int N = 30;
            List<Computer> ncomps = (from comp in computers where comp.Amount >= N select comp).ToList();
            foreach (Computer comp in ncomps)
            {
                Console.WriteLine($"{comp.Id} {comp.Brand} {comp.Cpu} {comp.CpuFrequency} {comp.MemoryVolume} {comp.DiskVolume} {comp.VideoVolume} {comp.Price} {comp.Amount}");
            }
            Console.ReadLine();
        }


        class Computer
        {
            public string Id { get; set; }
            public string Brand { get; set; }
            public string Cpu { get; set; }
            public int CpuFrequency { get; set; }
            public int MemoryVolume { get; set; }
            public int DiskVolume { get; set; }
            public int VideoVolume { get; set; }
            public double Price { get; set; }
            public int Amount { get; set; }
        }

    }
}
