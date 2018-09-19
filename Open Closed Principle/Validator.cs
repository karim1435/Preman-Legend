using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testinges;

namespace Open_Closed_Principle
{
    public abstract class Validator
    {
        public abstract bool Validate(Invoice invoice);
    }
}
