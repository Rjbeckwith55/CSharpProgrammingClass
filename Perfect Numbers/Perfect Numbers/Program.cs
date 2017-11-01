using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // all the factors of this number will add up to equal the number
            double perfect;
            for (int i = 2; i < 1000; i++)
            {
                perfect =  Convert.ToDouble((Math.Pow(2, i - 1)) * (Math.Pow(2, i - 1)));
                Console.WriteLine("Perfect numbers: " + perfect);
            }
            
            
        }
    }
}
