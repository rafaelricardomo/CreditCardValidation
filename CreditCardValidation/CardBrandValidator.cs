using System.Text.RegularExpressions;

namespace CreditCardValidation
{
    public class CardBrandValidator
    {
        private string _cardNumber;
        public CardBrandValidator(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public string GetBrand()
        {
            if (_cardNumber == null)
                return null;


            foreach (var item in CardBrandOptions.CardBrandsInfos)
            {
                if (Regex.IsMatch(_cardNumber, item.Regex))
                {
                    return item.Type.ToString();
                }
            }

            return null;
        }
    }
}
