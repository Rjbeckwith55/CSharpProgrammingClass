using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> nums = new Stack<int>();
            int NUMBERS = 1001;
            for (int i = 2; i < NUMBERS; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        nums.Push(j);
                    }


                }
                if (nums.Sum() == i)
                {
                    Console.WriteLine(i + " is a perfect number");
                }
                nums.Clear();

            }
        }
    }
}
