using Bad_TaxCalculator.Entity;

namespace Bad_TaxCalculator.Test
{
    public class IndividualTaxCalculatorTest
    {


        private TaXCalculator _calculator = new TaXCalculator();

        [Fact]
        public void Retired_Taxpayer_SHOULD_Pay_ONE_Percent_Tax()
        {
            //ARRANGE
            TaxPayer taxPayer = new TaxPayer
            {
                TaxCitizen = true,
                HasDisability = false,
                IsRetired = true
            };

            //Act
            var result = _calculator.CalculateTaxPercentage(taxPayer);

            //Assert
            Assert.Equal(1, result);
        }






        //[Fact]
        //public void Disable_Taxpayer_SHOULD_Pay_Zero_Percent_Tax()
        //{
        //    //ARRANGE
        //    TaxPayer taxPayer = new TaxPayer
        //    {
        //        TaxCitizen=true,
        //        HasDisability = true
        //    };
        //    IndividualTaxCalculator individualTaxCalculator = new IndividualTaxCalculator();

        //    //Act
        //   var Result= individualTaxCalculator.CalculateTaxPercentage(taxPayer);

        //    //Assert
        //    Assert.Equal(0, Result);
        //}


        //[Fact]
        //public void None_TaxResident_SHOULD_NOT_BE_Calculated()
        //{
        //    //ARRANGE
        //    TaxPayer taxPayer = new TaxPayer
        //    {
        //        TaxCitizen = false
        //    };
        //    IndividualTaxCalculator individualTaxCalculator = new IndividualTaxCalculator();

        //    //Act
        //    string expectedErrorMessage = "No TAX Calculation for NON-TAX Residents";

        //    var Exception_Result = Assert.Throws<InvalidOperationException>(() =>
        //    individualTaxCalculator.CalculateTaxPercentage(taxPayer));

        //    //Assert
        //    Assert.Equal(expectedErrorMessage, Exception_Result.Message);
        //}


    }
}