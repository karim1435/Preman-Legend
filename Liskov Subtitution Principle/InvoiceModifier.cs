using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testinges;

namespace Liskov_Subtitution_Principle
{
    public class InvoiceModifier
    {
        private Invoice _invoice;

        public InvoiceModifier(Invoice invoice)
        {
            this._invoice = invoice;
        }
        public void SetSubTotal(decimal subtotal)
        {
            _invoice.SubTotal = subtotal;
        }
        public void SetTaxRate(decimal taxRate)
        {
            _invoice.TaxRate = taxRate;
        }
        public Invoice GenerateInvoice()
        {
            return _invoice;
        }
    }
}
