using Interface_Segragation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Liskov_Subtitution_Principle;

namespace Testinges
{
    public class InvoicePrinter: IInvoicePrinter,ISomeOtherPrint
    {
        public void Print(Invoice invoice)
        {
            //logic goes here
            Console.WriteLine("Print Invoice");
            Console.WriteLine("Total is "+ invoice.SubTotal);
            Console.WriteLine("Tax rate is "+invoice.TaxRate);
        }

        public void PrintComplex(ComplexInvoice complexInvoice)
        {
            //Logic goes here
        }

        public void SomeOtherPrint(Invoice invoice)
        {
            //Logic goes here
        }
    }
}
