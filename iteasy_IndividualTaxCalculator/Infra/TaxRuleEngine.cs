using iteasy_IndividualTaxCalculator.Entity;
using iteasy_IndividualTaxCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteasy_IndividualTaxCalculator.Infra
{
    public class TaxRuleEngine
    {
        List<ITaxRule> _rules = new List<ITaxRule>();

        public TaxRuleEngine(IEnumerable<ITaxRule> rules)
        {
            _rules.AddRange(rules);
        }

        public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
        {
            foreach (var rule in _rules)
            {
                taxPayer.TaxedAmount += rule.CalculateTaxPercentage(taxPayer, taxPayer.TaxedAmount).TaxedAmount;
            }
            return taxPayer;
        }
    }
}
