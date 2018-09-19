using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ComplexInvoice
    {
        public decimal SubTotal { get; set; }
        public decimal TaxRate { get; set; }
        public decimal SecondTaxRate { get; set; }
        
        public decimal CalculateTax()
        {
            return (SubTotal * TaxRate / 100) +
                (SubTotal * SecondTaxRate / 100);
        }
        public decimal CalculateTotal()
        {
            return SubTotal + CalculateTax(); 
        }
    }
