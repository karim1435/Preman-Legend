using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public interface ISomeOtherPrint
    {
        void SomeOtherPrint(Invoice invoice);
    }
    public interface IInvoicePrinter
    {
        void Print(Invoice invoice);
        void PrintComplex(ComplexInvoice complexInvoice);
    }

