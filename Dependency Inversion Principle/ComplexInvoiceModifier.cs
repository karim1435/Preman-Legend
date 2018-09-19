using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ComplexInvoiceModifier
    {
        private ComplexInvoice _complexInvoice;

        public ComplexInvoiceModifier(ComplexInvoice complexInvoice)
        {
            this._complexInvoice = complexInvoice;
        }
        public void SetSubTotal(decimal subtotal)
        {
            _complexInvoice.SubTotal = subtotal;
        }
        public void SetTaxRate(decimal taxRate)
        {
            _complexInvoice.TaxRate = taxRate;
        }
        public void SetSecondTaxRate(decimal secondTaxRate)
        {
            _complexInvoice.SecondTaxRate = secondTaxRate;
        }
        public ComplexInvoice GenerateInvoice()
        {
            return _complexInvoice;
        }
    }

