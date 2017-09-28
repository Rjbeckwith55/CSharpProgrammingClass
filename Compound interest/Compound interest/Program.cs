using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_interest
{
    class Program
    {
        // Compound interest rate calculator without using only integers
        static void Main(string[] args)
        {
            int principal = 100000; //initial amount       before interest  
            int amount = principal; //amount on deposit at end of year           

            int rate = 5; //interest rate %
            Console.WriteLine("Year\t Amount on deposit");
            for (int year = 1; year <= 10; ++year)
            {
                amount = amount + ((amount * rate) / 100);
                //display amount               
                Console.WriteLine(""+year+"\t\t   $"+( amount/100)+"."+ amount % 100);
            }
            Console.ReadKey();
        }
    }

}
