using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class PrintingSystem
    {
        IInvoicePrinter _invoicePrinter;
        public PrintingSystem(IInvoicePrinter invoicePrinter)
        {
            this._invoicePrinter = invoicePrinter;
        }
        public void Print(Invoice invoice)
        {
            _invoicePrinter.Print(invoice);
        }
    }
