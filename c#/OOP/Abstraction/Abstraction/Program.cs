using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Shape shape1 = new Circle();
                Shape shape2 = new Square();

                shape1.Draw();    // Output: Drawing a circle.
                shape1.Display(); // Output: Displaying shape.

                shape2.Draw();    // Output: Drawing a square.
                shape2.Display(); // Output: Displaying shape.

                Console.ReadKey();

        }
    }
}
