using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Invoice invoice = new Invoice();
        invoice.SubTotal = 5000;
        invoice.TaxRate = 500;

        IInvoicePrinter invoicePrinter = new InvoicePrinter();
        PrintingSystem printSystem = new PrintingSystem(invoicePrinter);
        printSystem.Print(invoice);

        //Html

        IInvoicePrinter invoicePrinterHtml = new InvoicePrinterHtml();
        printSystem = new PrintingSystem(invoicePrinterHtml);
        printSystem.Print(invoice);

        //Xaml 
        IInvoicePrinter invoicePrinterXaml = new InvoicePrinterXaml();
        printSystem = new PrintingSystem(invoicePrinterXaml);
        printSystem.Print(invoice);

        List<IInvoicePrinter> invoicePrinters = new List<IInvoicePrinter>();

        invoicePrinters.Add(new InvoicePrinter());
        invoicePrinters.Add(new InvoicePrinterHtml());
        invoicePrinters.Add(new InvoicePrinterXaml());

        Console.WriteLine();
        Console.WriteLine("List of printer invoice");
        foreach (var printer in invoicePrinters)
        {
            printSystem = new PrintingSystem(printer);
            printSystem.Print(invoice);
        }
     }
}

