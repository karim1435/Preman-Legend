using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testinges;

namespace Liskov_Subtitution_Principle
{
    public class ComplexInvoice:Invoice
    {
        public decimal SecondTaxRate { get; set; }
        
        public new  decimal CalculateTotal()
        {
            return (SubTotal * TaxRate / 100) +
                (SubTotal * SecondTaxRate / 100);
        }
    }
}
