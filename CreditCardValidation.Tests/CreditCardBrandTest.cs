using Xunit;

namespace CreditCardValidation.Tests
{
    public class CreditCardBrandTest : BaseCreditCardDataTest
    {

        [Fact]
        public void CreditCardBrand_cards_v1_Valid()
        {
            // test card data
            foreach(var card in cards)
            {
                var brand = CreditCardValidationHelper.GetBrand(card);

                Assert.NotNull(brand);
            }

        }

        [Fact]
        public void CreditCardBrand_cards_v2_Valid()
        { 

            // test card data V2
            foreach (var card in cardsV2)
            {
                var brand = CreditCardValidationHelper.GetBrand(card);

                Assert.NotNull(brand);
            }

        }

        [Fact]
        public void CreditCardBrand_Invalid()
        {
            var card = "32a3as1d3a1d32as1d32as";
            var brand = CreditCardValidationHelper.GetBrand(card);

            Assert.Null(brand);

        }

        [Fact]
        public void CreditCardBrand_Null_Invalid()
        {            
            var brand = CreditCardValidationHelper.GetBrand(null);

            Assert.Null(brand);

        }

        [Fact]
        public void CreditCardBrand_empty_Invalid()
        {
            var brand = CreditCardValidationHelper.GetBrand(string.Empty);

            Assert.Null(brand);

        }

        [Fact]
        public void CreditCardBrand_valid()
        {
            var card = "6062828380821112";
            var brand = CreditCardValidationHelper.GetBrand(card);

            Assert.NotNull(brand);

        }


    }
}