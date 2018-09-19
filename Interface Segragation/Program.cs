using Liskov_Subtitution_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testinges;

namespace Interface_Segragation
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.SubTotal = 1000;
            invoice.TaxRate = 50;

            InvoicePrinter printer = new InvoicePrinter();
            Console.WriteLine("Before");
            printer.Print(invoice);

            InvoiceModifier edit = new InvoiceModifier(invoice);
            edit.SetTaxRate(400);
            edit.SetSubTotal(4000);
            invoice = edit.GenerateInvoice();
            Console.WriteLine("After");
            printer.Print(invoice);

        }
    }
}
