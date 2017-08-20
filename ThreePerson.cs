using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreePerson
{
    class Person
    {
        public int age;
        public string name;
        public string gender;
    }
    class Employee : Person
    {
        public Employee()
        {
        }

        public Employee(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public void display()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("\nAge: " + age);
            Console.WriteLine("\nGender: " + gender);
            Console.WriteLine("--------------------------------------------------------------");
        }
        public void specialistDisplay()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("\nAge: " + age);
            Console.WriteLine("\nGender: " + gender);
            Console.WriteLine("--------------------------------------------------------------");
        }
    }
    class Specialist : Employee
    {
        public Specialist(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try {
                Employee[] objEmployee = new Employee[3];
                Specialist[] objSpecialist = new Specialist[3];
                Console.WriteLine("-----------------EMPLOYEE REGISTRATION------------------");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("\nEnter the {0} employee details: \n", i + 1);
                    Console.WriteLine("\nEnter the employee name: \n");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nEnter the employee age: \n");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter the employee gender: \n");
                    string gender = Console.ReadLine();
                    objEmployee[i] = new Employee(name, age, gender);
                }
                Console.WriteLine("---------------------SPECIALIST REGISTRATION------------------");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("\nEnter the {0} specialist details: \n", i + 1);
                    Console.WriteLine("\nEnter the specialist name: \n");
                    string name = Console.ReadLine();
                    Console.WriteLine("\nEnter the specialist age: \n");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nEnter the specialist gender: \n");
                    string gender = Console.ReadLine();
                    objSpecialist[i] = new Specialist(name, age, gender);
                }
                Console.WriteLine("\n-----------------------EMPLOYEE DETAILS----------------------");
                for (int i = 0; i < 3; i++)
                {
                    objEmployee[i].display();
                }
                Console.WriteLine("\n-----------------------SPECIALIST DETAILS----------------------");
                for (int i = 0; i < 3; i++)
                {
                    objSpecialist[i].specialistDisplay();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\nInvalid Data!");
            }
            Console.ReadLine();
        }
    }
}
