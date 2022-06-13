using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteasy_IndividualTaxCalculator.Entity
{
    public class TaxPayer
    {
        public double GrossIncome { get; set; }
        public bool IsSingle { get; set; }
        public bool IsRetired { get; set; }
        public bool IsResidentOrCitizen { get; set; }
        public bool HasHealthInsurance { get; set; }
        public bool HasBusiness { get; set; }
        public bool AtLossInBusiness { get; set; }
        public double TaxedAmount { get; set; }
        public double HealthInsuranceAnnualPremium { get; set; }
    }
}
