using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            String numbers;
            Console.WriteLine("Enter in a 5 digit nubmer to determine if it is a palindrome: ");
            numbers = Console.ReadLine();
            if (numbers.Length == 5)
            {
                if (numbers[0] == numbers[4])
                {
                    if (numbers[1] == numbers[3])
                    {
                        Console.WriteLine("This is a Palindrome");
                    }
                    else
                        Console.WriteLine("Not a palindrome");
                }
                else
                    Console.WriteLine("Not a palindrome");
            }
            else
            {
                while(numbers.Length != 5)
                {
                    Console.WriteLine("Enter in a 5 digit nubmer to determine if it is a palindrome: ");
                    numbers = Console.ReadLine();
                }
            }
        
        }
    }
}
