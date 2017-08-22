using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._28
{
    class FiveDigits
    {
        static void Main(string[] args)
        {
            String Number = "";

            while (Number.Length != 5) // Prevents the user from entering in a number that doesn't have exactly 5 digits
            {
                Console.Write("Enter in a five digit number: ");
                Number = Console.ReadLine();
            }

            //Loops through and prints out the digits of the number with 3 spaces after
            for (int i = 0; i < Number.Length; i++)
            {
                Console.Write(Number[i] + "   ");
            }
            Console.ReadKey();
        }

    }
}
