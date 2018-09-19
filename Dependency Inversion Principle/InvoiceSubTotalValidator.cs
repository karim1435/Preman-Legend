using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    public class InvoiceTaxValidator : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            return invoice.CalculateTax() >= 0;
        }
    }
    public class InvoiceTotalValidator : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            return invoice.CalculateTotal() >= 0;
        }
    }
    public class InvoiceTaxRateValidator : Validator
    {
        public override bool Validate(Invoice invoice)
        {
            return invoice.TaxRate >= 0;
        }
    }
public class InvoiceSubTotalValidator : Validator
{
    public override bool Validate(Invoice invoice)
    {
        return invoice.SubTotal >= 0;
    }
}
