using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Method_Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle();
            Shape shape2 = new Square();

            shape1.Draw(); // Output: Drawing a circle.
            shape2.Draw(); // Output: Drawing a square.

            Console.ReadKey();
        }
    }
}
