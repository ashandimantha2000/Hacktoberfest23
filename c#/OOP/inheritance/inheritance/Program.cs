using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "Generic Animal";
            animal.MakeSound();

            Dog dog = new Dog();
            dog.Name = "Buddy";
            dog.MakeSound();
            dog.WagTail();

            Console.ReadKey();
        }
    }
}
