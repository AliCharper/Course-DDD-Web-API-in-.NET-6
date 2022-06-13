using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bad_TaxCalculator.Entity
{
    public class TaxPayer
    {
        public bool TaxCitizen { get; set; }
        public bool HasDisability { get; set; }
        public bool IsMuslim { get; set; }
        public decimal ZakatPaid { get; set; }
        public bool IsRetired { get; set; }
        public bool MaritalStatus { get; set; }

    }

}
