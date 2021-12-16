using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public string name;
        public abstract string Name { get; set; }
        public Animal()
        {
            Name = name;
        }
               
        
        public abstract string Say();
        

        public void ShowInfo()
        {
            Console.Write(Name);
            Console.Write(Say());
            Console.WriteLine();
        }
    }
    class Cat:Animal
    {
       
        public override string Name { get { return "Кошка"; } set { name = value; } }
        
        


        public override string Say()
        {
           return " - мяу";
        }
    }
    class Dog : Animal
    {
        public override string Name { get { return "Собака"; } set { name = value; } }
        

        public override string Say()
        {
            return " - гав";
        }
    }
}
