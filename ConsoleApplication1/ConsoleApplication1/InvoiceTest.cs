using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            double invoiceTotal;
            //create a invoice object
            Invoice I = new Invoice();

            Console.Write("Input the part number: ");
            I.partNumber =Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the part description: ");
            I.partDescription = Console.ReadLine();

            Console.Write("Input the quantity of parts: ");
            I.quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the price of the part: $");
            I.price = Convert.ToDouble(Console.ReadLine());

            if(I.price!=0 && I.quantity != 0)
            {
                Console.WriteLine("Partnumber: " + I.partNumber + "\nDescription: " + I.partDescription + "\nQuantity: " + I.quantity + "\nPrice: $" + I.price);

                invoiceTotal = I.getInvoiceAmount();
                Console.WriteLine("The total invoice amount: $" + invoiceTotal);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
/*SAMPLE OUTPUT
Input the part number: 123
Input the part description: Tool
Input the quantity of parts: 43
Input the price of the part: $23.30
Partnumber: 123
Description: Tool
Quantity: 43
Price: $23.3
The total invoice amount: $1001.9
Press any key to continue . . .
*/