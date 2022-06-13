using iteasy_IndividualTaxCalculator.Entity;
using iteasy_IndividualTaxCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteasy_IndividualTaxCalculator.Infra.TaxRules
{
    public class RetiredRule : ITaxRule
    {
        public int CalculateTaxPercentage(TaxPayer taxPayer, int currentPercentage)
        {
            if (taxPayer.IsRetired)

            {
                return 1;
            }
            return 0;
        }
    }
}
