using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testinges
{
    public class Invoice
    {
        public decimal SubTotal { get; set; }
        public decimal TaxRate { get; set; }

        public decimal CalculateTax()
        {
            return SubTotal * TaxRate / 100;
        }
        public decimal CalculateTotal()
        {
            return SubTotal + CalculateTax();
        }
        public void Print(Invoice invoice)
        {
            Console.WriteLine("your tax is " + invoice.CalculateTax());
            Console.WriteLine("and the total is " + invoice.CalculateTotal());
             
        }
    }
}
