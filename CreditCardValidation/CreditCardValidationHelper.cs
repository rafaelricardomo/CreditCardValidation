namespace CreditCardValidation
{
    public static class CreditCardValidationHelper
    {
        public static bool IsNumberValid(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber))
                return false;

            var cardNumberValidator = new CardNumberValidator(cardNumber);

            return cardNumberValidator.IsValid();
        }

        public static string GetBrand(string cardNumber)
        {
            if (string.IsNullOrEmpty(cardNumber))
                return null;

            var cardBrandValidator = new CardBrandValidator(cardNumber);

            return cardBrandValidator.GetBrand();

        }

    }


}
