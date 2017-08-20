using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoBaseClass
{
    class Animal
    {
        public string name;
        public float age;
        public void display()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("\nAge: " + age);
        }
    }
    class Cat : Animal
    {
        public Cat(string name, float age)
        {
            this.name = name;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("\nAge: " + age);
        }
    }
    class Dog : Animal
    {
        public Dog(string name, float age)
        {
            this.name = name;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("\nAge: " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number of cats: \n");
                int catSize = int.Parse(Console.ReadLine());
                Cat[] objCat = new Cat[catSize];
                for (int i = 0; i < catSize; i++)
                {
                    Console.WriteLine("\nEnter the {0} cat information: \n",i+1);
                    Console.WriteLine("\nEnter the name: \n");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nEnter the age: \n");
                    float age = float.Parse(Console.ReadLine());
                    objCat[i] = new Cat(name, age);
                }
                Console.WriteLine("\nEnter the number of dogs: \n");
                int dogSize = int.Parse(Console.ReadLine());
                Dog[] objDog = new Dog[dogSize];
                for (int i = 0; i < dogSize; i++)
                {
                    Console.WriteLine("\nEnter the {0} dog information: \n",i+1);
                    Console.WriteLine("\nEnter the name: \n");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nEnter the age: \n");
                    float age = float.Parse(Console.ReadLine());
                    objDog[i] = new Dog(name, age);
                }
                Console.WriteLine("\nThe detailed information of cats and dogs are \n");
                Console.WriteLine("\nDetails of cat");
                for (int i = 0; i < catSize; i++)
                {
                    objCat[i].display();
                }
                Console.WriteLine("\nDetails of dog");
                for (int i = 0; i < dogSize; i++)
                {
                    objDog[i].display();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid data!");
            }
            Console.ReadLine();
        }
    }
}
