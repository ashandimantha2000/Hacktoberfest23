using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John Doe";
            person.Age = 30;

            person.DisplayInfo();

            Console.ReadKey();
        }
    }
}
