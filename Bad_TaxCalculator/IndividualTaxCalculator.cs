using Bad_TaxCalculator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bad_TaxCalculator
{
    public class IndividualTaxCalculator
    {
        public int CalculateTaxPercentage(TaxPayer taxPayer)
        {
            if (!taxPayer.TaxCitizen)
            {
                throw new InvalidOperationException("No TAX Calculation for NON-TAX Residents");
            }
            return 0;
        }
    }
}
