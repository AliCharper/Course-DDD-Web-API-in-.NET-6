using Bad_TaxCalculator.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bad_TaxCalculator
{
    public interface ITaxRule
    {
        int CalculateTaxPercentage(TaxPayer taxPayer, int currentPercentage);
    }
    //
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
    //
    public class TaxRuleEngine
    {
        List<ITaxRule> _rules = new List<ITaxRule>();

        public TaxRuleEngine(IEnumerable<ITaxRule> rules)
        {
            _rules.AddRange(rules);
        }

        public int CalculateTaxPercentage(TaxPayer taxPayer)
        {
            int TaxPercentage = 0;
            foreach (var rule in _rules)
            {
                TaxPercentage = Math.Max(TaxPercentage, rule.CalculateTaxPercentage(taxPayer, TaxPercentage));
            }
            return TaxPercentage;
        }
    }
    //
    public class TaXCalculator
    {
        public int CalculateTaxPercentage(TaxPayer taxPayer)
        {
            var ruleType = typeof(ITaxRule);
            IEnumerable<ITaxRule> rules = this.GetType().Assembly.GetTypes()
                .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                .Select(r => Activator.CreateInstance(r) as ITaxRule);

            var engine = new TaxRuleEngine(rules);

            return engine.CalculateTaxPercentage(taxPayer);
        }
    }

    //
    public class IndividualTaxCalculator
    {
        public int CalculateTaxPercentage(TaxPayer taxPayer)
        {
            if (!taxPayer.TaxCitizen)
            {
                throw new InvalidOperationException("No TAX Calculation for NON-TAX Residents");
            }
            else
            {
                if (taxPayer.HasDisability)
                {
                    return 0;
                }
                //
                if (taxPayer.IsMuslim)
                {
                    if (taxPayer.ZakatPaid > 10000 && taxPayer.ZakatPaid < 50000)
                    {
                        return 5;
                    }
                    if (taxPayer.ZakatPaid > 10000 && taxPayer.ZakatPaid < 100000)
                    {
                        return 4;
                    }
                    if (taxPayer.ZakatPaid > 100000 && taxPayer.ZakatPaid < 200000)
                    {
                        return 3;
                    }
                }
                //
                if (taxPayer.IsRetired)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
