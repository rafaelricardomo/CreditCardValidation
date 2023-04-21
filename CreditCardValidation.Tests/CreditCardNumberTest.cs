using Xunit;

namespace CreditCardValidation.Tests
{
    public class CreditCardNumberTest : BaseCreditCardDataTest
    {

        [Fact]
        public void CreditCardNumber_cards_v1_Valid()
        {
            // test card data
            foreach(var card in cards)
            {
                var valid = CreditCardValidationHelper.IsNumberValid(card);

                Assert.True(valid);
            }

        }

        [Fact]
        public void CreditCardNumber_cards_v2_Valid()
        { 

            // test card data V2
            foreach (var card in cardsV2)
            {
                var valid = CreditCardValidationHelper.IsNumberValid(card);

                Assert.True(valid);
            }

        }

        [Fact]
        public void CreditCardNumber_Invalid()
        {
            var card = "32a3as1d3a1d32as1d32as";
            var valid = CreditCardValidationHelper.IsNumberValid(card);

            Assert.False(valid);

        }

        [Fact]
        public void CreditCardNumber_Null_Invalid()
        {            
            var valid = CreditCardValidationHelper.IsNumberValid(null);

            Assert.False(valid);

        }

        [Fact]
        public void CreditCardNumber_Empty_Invalid()
        {            
            var valid = CreditCardValidationHelper.IsNumberValid(string.Empty);

            Assert.False(valid);

        }

        [Fact]
        public void CreditCardNumber_valid()
        {
            var card = "869906133058105";
            var valid = CreditCardValidationHelper.IsNumberValid(card);

            Assert.True(valid);

        }


    }
}