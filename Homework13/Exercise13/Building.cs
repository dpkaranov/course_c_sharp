using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Building
    {
        string address;
        double length, width, height;
        public Building()
        {

        }
        public Building(string address, double length, double width, double height) {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public string Address {
            set { this.address = value; }
            get { return address; } 
        }

        public double Length {
            set { this.length = value; }
            get { return length; } 
        }

        public double Width { 
            set { this.width = value; }
            get { return width; } 
        }

        public double Height { 
            set { this.height = value; } 
            get { return height; }
        }

        public void Print()
        {
            Console.WriteLine($"Адрес : {address}\nДлина: {length}\nШирина {width}\nВысота {height}");
        }
    }

    sealed class MultiBuilding:Building
    {
        int levels;
        public MultiBuilding(string address, double length, double width, double height, int levels):base(address, length, width, height) 
        {
            this.levels = levels;
        }

        public int Levels { 
            set { this.levels = value; }
            get { return levels; } 
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Кол-во этажей - {levels}");
        }
    }
}
