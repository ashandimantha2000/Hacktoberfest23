using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Circle();
            IShape shape2 = new Square();

            shape1.Draw();    // Output: Drawing a circle.

            shape2.Draw();    // Output: Drawing a square.

            Console.ReadKey();
        }
    }
}
