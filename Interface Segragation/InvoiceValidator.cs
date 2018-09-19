using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testinges;

namespace Open_Closed_Principle
{
    public class InvoiceValidator
    {
        private List<Validator> _validators;
        public InvoiceValidator(List<Validator> validator)
        {
            this._validators = validator;
        }
        public bool Validator(Invoice invoice)
        {
            return _validators.All(v => v.Validate(invoice));
        }
    }
}
