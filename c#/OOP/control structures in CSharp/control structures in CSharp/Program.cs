using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_structures_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their age
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            // Check if the user is eligible to vote
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote yet.");
            }

            // Prompt the user for a day of the week
            Console.WriteLine("Enter a day of the week:");
            string dayOfWeek = Console.ReadLine();

            // Use switch-case to perform different actions based on the day of the week
            switch (dayOfWeek.ToLower())
            {
                case "monday":
                    Console.WriteLine("It's the start of the week.");
                    break;
                case "friday":
                    Console.WriteLine("It's the end of the week.");
                    break;
                case "saturday":
                case "sunday":
                    Console.WriteLine("It's the weekend!");
                    break;
                default:
                    Console.WriteLine("It's a regular weekday.");
                    break;
            }

            // Use a for loop to count from 1 to 5
            Console.WriteLine("Counting from 1 to 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // Use a while loop to count from 1 to 5
            Console.WriteLine("Counting from 1 to 5 using a while loop:");
            int counter = 1;
            while (counter <= 5)
            {
                Console.WriteLine(counter);
                counter++;
            }

            // Use a do-while loop to greet the user at least once
            string name;
            do
            {
                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));

            Console.WriteLine($"Hello, {name}!");

            // Wait for the user to press a key before exiting
            Console.ReadKey();
        }
    }
}
