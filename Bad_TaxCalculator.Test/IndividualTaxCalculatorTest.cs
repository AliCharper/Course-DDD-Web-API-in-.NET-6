using Bad_TaxCalculator.Entity;

namespace Bad_TaxCalculator.Test
{
    public class IndividualTaxCalculatorTest
    {

        [Fact]
        public void None_TaxResident_SHOULD_NOT_BE_Calculated()
        {
            //ARRANGE
            TaxPayer taxPayer = new TaxPayer
            {
                TaxCitizen = false
            };
            IndividualTaxCalculator individualTaxCalculator = new IndividualTaxCalculator();

            //Act
            string expectedErrorMessage = "No TAX Calculation for NON-TAX Residents";

            var Exception_Result = Assert.Throws<InvalidOperationException>(() =>
            individualTaxCalculator.CalculateTaxPercentage(taxPayer));

            //Assert
            Assert.Equal(expectedErrorMessage, Exception_Result.Message);
        }


    }
}