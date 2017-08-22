using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._17
{
    class Comparison
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int average, sum, product, largest,smallest;

            //Prompt and read input
            Console.WriteLine("Input the first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third integer: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            //Calculate the sum average product max and min
            sum = num1 + num2 + num3;
            average = sum/3;
            product = num1 * num2 * num3;
            largest = num1;
            smallest = num1;
            if (num2 > largest)
            {
                largest = num1;
            }
            if (num3> largest)
            {
                largest = num3;
            }
            if (num2 < smallest)
            {
                smallest = num2;
            }
            if (num3 < smallest)
            {
                smallest = num3;
            }
            Console.WriteLine("Sum: "+ sum);
            Console.WriteLine("Average: "+ average);
            Console.WriteLine("Product: "+ product);
            Console.WriteLine("Largest: "+ largest);
            Console.WriteLine("Smallest: "+ smallest);
            Console.ReadKey();


        }
    }
}
