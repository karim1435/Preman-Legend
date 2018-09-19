using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class InvoicePrinterHtml : IInvoicePrinter
{
    public void Print(Invoice invoice)
    {
        Console.WriteLine("Print format html of invoice");
    }
    public void PrintComplex(ComplexInvoice complexInvoice)
    {
        //Logic goes here
    }
}
