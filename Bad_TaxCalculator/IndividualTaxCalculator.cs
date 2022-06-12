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
