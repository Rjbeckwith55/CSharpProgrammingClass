using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNBB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string s = Console.ReadLine();

            int loops = Convert.ToInt32(s);
            try
            {


                for (int i = loops; i > 0; i--)
                {
                    Console.WriteLine(i + " bottles of beer on the wall...");
                    Console.WriteLine(i + " bottles of beer");

                }
            }
            catch(Exception)
            {
                Console.WriteLine("I think you have too many bottles");
            }
            Console.ReadKey();
        }
    }
}
