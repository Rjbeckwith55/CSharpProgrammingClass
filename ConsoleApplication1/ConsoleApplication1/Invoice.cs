using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Invoice
    {
        private int Quantity;
        private double Price;
        public int partNumber { get; set; }
        public string partDescription { get; set; }
        public int quantity {
            get { return Quantity; }
            set
            {
                if (value >= 0)
                {
                    Quantity = value;
                }
                else
                {
                    return;
                }
                    
            }
        }
    
        public double price
        {
            get { return Price; }
            set
            {
                if (value >= 0)
                    Price = value;
            }
        }
        public double getInvoiceAmount()
        {
            return (price * quantity);
        }
    }
}
