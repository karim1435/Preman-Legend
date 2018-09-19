using Liskov_Subtitution_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testinges;

namespace Interface_Segragation
{
    public interface ISomeOtherPrint
    {
        void SomeOtherPrint(Invoice invoice);
    }
    public interface IInvoicePrinter
    {
        void Print(Invoice invoice);
        void PrintComplex(ComplexInvoice complexInvoice);
    }
}
