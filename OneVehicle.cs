using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneVehicle
{
    class Vehicle
    {
        public void print()
        {
            Console.WriteLine("In Vehicle Class....");
        }
    }
    class Car : Vehicle
    {
        public void print()
        {
            Console.WriteLine("In Car Class......");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            obj.print();
            Console.ReadLine();
        }
    }
}
