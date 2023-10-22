using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int result1 = calculator.Add(2, 3);
            int result2 = calculator.Add(2, 3, 4);

            Console.WriteLine(result1); // Output: 5
            Console.WriteLine(result2); // Output: 9

            Console.ReadKey();
        }
    }
}
