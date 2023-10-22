using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Method_Overriding
{
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }
}
