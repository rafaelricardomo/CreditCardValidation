namespace CreditCardValidation
{
    public class CardNumberValidator
    {
        private string _cardNumber;
        public CardNumberValidator(string cardNumber)
        {
            _cardNumber = cardNumber;
        }
        public bool IsValid()
        {
            int i, checkSum = 0;

            for (i = _cardNumber.Length - 1; i >= 0; i -= 2)
                checkSum += (_cardNumber[i] - '0');

            for (i = _cardNumber.Length - 2; i >= 0; i -= 2)
            {
                int val = ((_cardNumber[i] - '0') * 2);
                while (val > 0)
                {
                    checkSum += (val % 10);
                    val /= 10;
                }
            }

            return ((checkSum % 10) == 0);
        }
    }
}
