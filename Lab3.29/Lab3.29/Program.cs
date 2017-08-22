using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number\tSquare\tCube");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i + "\t" + i * i + "\t" + i * i * i);
            }
            Console.ReadKey();
        }
    }
}
