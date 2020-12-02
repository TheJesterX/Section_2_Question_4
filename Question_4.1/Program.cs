// Jacobus Rothmann

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool continued = true;
            // Do allow for multiple uses
            while (continued == true)
            {
                int number, ctr, j = 0;
                List<int> primeList = new List<int>();
                Console.Write("Find the prime number in any position :\n");
                // Allows the user to check any prime number position
                Console.Write("Enter the position number : ");
                int finalNumber = Convert.ToInt32(Console.ReadLine());
                // Check is the number is a prime number
                for (number = 1; j <= finalNumber; number++)
                {
                    ctr = 0;
                    for (int i = 2; i <= number / 2; i++)
                    {
                        if (number % i == 0)
                        {
                            ctr++;
                            break;
                        }
                    }
                    if (ctr == 0 && number != 1)
                    {
                        // Adds the number to the primeList if the number is a prime number 
                        primeList.Add(number);
                        j++;
                    }
                }
                // Changes the list into an array 
                int[] primeNumbers = primeList.ToArray();
                // Displayes the value of the final answer
                Console.Write("The {0} prime number is : {1}",(j-1),primeNumbers[(j - 2)]);
                // Asks the user if they want to continue
                Console.WriteLine("\nDo you want to check another number? (Y/N)");
                string answer = Console.ReadLine().ToUpper();
                // If the answer is N the application stops
                if (answer == "N")
                {
                    continued = false;
                }
                else
                {
                    Console.Clear();
                }
            }         
        }
    }
}
