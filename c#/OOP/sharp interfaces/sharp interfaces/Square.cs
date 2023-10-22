using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_interfaces
{
    class Square :IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }
}
