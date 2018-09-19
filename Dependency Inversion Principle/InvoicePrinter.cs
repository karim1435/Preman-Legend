using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class InvoicePrinter: IInvoicePrinter
    {
        public void Print(Invoice invoice)
        {
            //logic goes here
            Console.WriteLine("Print format text of invoice");
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
