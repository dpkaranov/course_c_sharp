using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine($"Имя животного - {Name}");
            Say();
        }
    }

    class Cat : Animal
    {
        public string name;
        public string voice;

        public Cat(string name):base(name)
        {
            this.name = name;
            this.voice = "Мяу!";
        }

        public override string Name
        {
            set { name = value; }
            get { return name; }
        }

        
        public override void Say()
        {
            Console.WriteLine(voice);
        }

    }

    class Dog : Animal
    {
        public string name;
        public string voice;

        public Dog(string name):base(name)
        {
            this.name = name;
            this.voice = "Гав!";
        }

        public override string Name
        {
            set { name = value; }
            get { return name; }
        }

        public override void Say()
        {
            Console.WriteLine(voice);
        }

    }
}
