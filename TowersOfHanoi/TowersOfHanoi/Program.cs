using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Program
    {
        public static void Main(String[] args)
        {
            //ask for the number of disks
            Console.WriteLine("Enter the number of pegs in the tower: ");
            int totalDisks = Convert.ToInt32(Console.ReadLine());
            // declare the variables
            char startPeg = 'A'; 
            char endPeg = 'C';
            char tempPeg = 'B';
            // recursively call itself
            solveTowers(totalDisks, startPeg, endPeg, tempPeg);

        }

        private static void solveTowers(int n, char startPeg, char endPeg, char tempPeg)
        {
            if (n > 0)
            {
                solveTowers(n - 1, startPeg, tempPeg, endPeg);
                // print the towers moving
                Console.WriteLine("Move disk from " + startPeg + ' ' + endPeg);
                solveTowers(n - 1, tempPeg, endPeg, startPeg);

            }
        }
    }
}
