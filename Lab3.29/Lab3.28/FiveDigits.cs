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
            while (Number.Length != 5)
            {
                Console.Write("Enter in a five digit number: ");
                Number = Console.ReadLine();
            }
            for (int i = 0; i < Number.Length; i++)
            {
                Console.Write(Number[i] + "   ");
            }
            Console.ReadKey();
        }

    }
}
