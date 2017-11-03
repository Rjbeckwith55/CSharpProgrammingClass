using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoi
{
    class Program
    {
        public static Stack<int> original = new Stack<int>();       //I used 3 stacks, to make sure that only the top disk can be taken
        public static Stack<int> temp = new Stack<int>();
        public static Stack<int> final = new Stack<int>();

        public static int oneHash = original.GetHashCode();         //Use the hash codes to keep track of the stacks as they change names
        public static int twoHash = temp.GetHashCode();
        public static int threeHash = final.GetHashCode();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of discs: ");       //ask user for number of disks
            int diskNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < diskNum + 2; i++)
            {
                original.Push(i);                                   //fill the first tower with numbers, their values dont matter, 
            }

            Move(diskNum + 1, original, temp, final);               //Calls the Move function on the lowest disc

        }


        public static void Move(int num, Stack<int> original, Stack<int> temp, Stack<int> final)
        {
            if (num == 1)                                           //if the highest disc gets passed, returns
            {
                return;
            }

            Move(num - 1, original, final, temp);                   //Calls itself, but passes the ring above the current one and sets the temp tower, as the final

            int hold = original.Pop();                             //pops a disc from the original tower and pushes it on the final tower
            final.Push(hold);

            //Uses the ToNum function to show between which towers the disc switched. 
            Console.WriteLine(Convert.ToString(ToNum(original.GetHashCode()) + " ==> " + ToNum(final.GetHashCode())));

            Move(num - 1, temp, original, final);       //Calls itself, for the ring above it and moves it to the final ring.
        }

        public static string ToNum(int v)
        {
            if (v == oneHash)
            {
                return "1";                             //if the hash value sent matches the one of the first stack, returns 1
            }
            else if (v == twoHash)
            {
                return "2";                             //if it matches with the second, returns 2
            }
            else
            {
                return "3";                             //if it matches with the third, returns 3
            }
        }
    }
}
