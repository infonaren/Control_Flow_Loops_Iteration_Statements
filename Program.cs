using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow_Loops_Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = 0;
            // do while loop
            do

            {
                Console.WriteLine("Enter the numbers from 0 to 10: {0}", j);
                j++;
            } while (j <= 10);

            // Traditional for loop
            for (var i = 0; i <=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Printing the even numbers in ascending order between 0 and 10: " + i);
                }
            }

          for (var i = 10; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Printing the even numbers in descending order between 10 and 0: " + i);
                }
            }

            var name = "Arjun Reddy";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // foreach loop

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] { 8, 9, 10, 12 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // while loop

            while (true)
            {
                Console.WriteLine("Type your name: ");
                var userInput = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userInput))
                    break;

                Console.WriteLine("@Echo: " + userInput);
            }


            while (true)
            {
                Console.WriteLine("Type your name: ");
                var userrInput = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(userrInput))
                {
                    Console.WriteLine("@Echo: " + userrInput);
                    continue;
                }
                break;

              

            }

        }
    }
}
