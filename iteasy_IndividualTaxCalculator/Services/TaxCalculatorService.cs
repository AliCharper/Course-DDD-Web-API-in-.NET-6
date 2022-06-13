using iteasy_IndividualTaxCalculator.Entity;
using iteasy_IndividualTaxCalculator.Infra;
using iteasy_IndividualTaxCalculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteasy_IndividualTaxCalculator.Services
{
    public class TaxCalculatorService
    {        
            public TaxPayer CalculateTaxPercentage(TaxPayer taxPayer)
            {
                var ruleType = typeof(ITaxRule);
                IEnumerable<ITaxRule> rules = this.GetType().Assembly.GetTypes()
                    .Where(p => ruleType.IsAssignableFrom(p) && !p.IsInterface)
                    .Select(r => Activator.CreateInstance(r) as ITaxRule);

                var engine = new TaxRuleEngine(rules);

                return engine.CalculateTaxPercentage(taxPayer);
            }
        }
    }

