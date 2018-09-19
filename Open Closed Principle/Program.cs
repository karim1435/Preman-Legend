using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testinges;

namespace Open_Closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.SubTotal = 100;
            invoice.TaxRate = 200;

            List<Validator> validators = new List<Validator>();
            validators.Add(new InvoiceSubTotalValidator());
            validators.Add(new InvoiceTaxRateValidator());
            validators.Add(new InvoiceTotalValidator());
            validators.Add(new InvoiceTaxValidator());

            InvoiceValidator validator = new InvoiceValidator(validators);

            bool valid = validator.Validator(invoice);

            InvoicePrinter printer = new InvoicePrinter();

            if (valid)
                printer.Print(invoice);
            else Console.WriteLine("Check your input");
        }
    }
}
