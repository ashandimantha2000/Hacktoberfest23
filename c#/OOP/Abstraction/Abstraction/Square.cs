using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }
}
