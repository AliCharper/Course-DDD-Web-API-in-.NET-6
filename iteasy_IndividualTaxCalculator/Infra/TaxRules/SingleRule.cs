using iteasy_IndividualTaxCalculator.Entity;
using iteasy_IndividualTaxCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteasy_IndividualTaxCalculator.Infra.TaxRules
{
    public class SingleRule : ITaxRule
    {
        public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer, double currentPercentage)
        {
            if (taxPayer.IsSingle)
                taxPayer.TaxedAmount += ((taxPayer.GrossIncome - 40000) * .1);
            return taxPayer;
        }
    }
}
