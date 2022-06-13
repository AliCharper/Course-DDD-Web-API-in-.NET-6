using iteasy_IndividualTaxCalculator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteasy_IndividualTaxCalculator.Interface
{
    public interface ITaxRule
    {
        TaxPayer CalculateTaxPercentage(TaxPayer taxPayer, double currentPercentage);
    }
}
