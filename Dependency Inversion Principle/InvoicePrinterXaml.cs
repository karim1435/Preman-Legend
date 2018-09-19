using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class InvoicePrinterXaml : IInvoicePrinter
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine("Print format xaml of invoice");
        }
        public void PrintComplex(ComplexInvoice complexInvoice)
        {
           //Logic goes here
        }
    }