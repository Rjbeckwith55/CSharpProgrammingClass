using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._24
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter in a number");
            num = Convert.ToInt32(Console.Read());
            if (num % 2 == 1)
            {
                Console.WriteLine("Odd");

            }
            else
                Console.WriteLine("Even");
            Console.ReadKey();
        }
    }
}
