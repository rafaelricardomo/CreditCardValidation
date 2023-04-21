namespace CreditCardValidation
{

    public struct CardBrandInfo
    {
        public CardBrandInfo(CardBrandType type, string regex)
        {
            Type = type;
            Regex = regex;
        }

        public CardBrandType Type { get; private set; }

        public string Regex { get; private set; }



        public readonly static CardBrandInfo Elo = new CardBrandInfo(
              CardBrandType.Elo,
               @"^((((636368)|(438935)|(504175)|(451416)|(636297))\d{0,10})|((5067)|(4576)|(4011))\d{0,12})$"
           );

        public readonly static CardBrandInfo Elo2 = new CardBrandInfo(
              CardBrandType.Elo,
             @"^(40117[8-9]|431274|438935|451416|457393|45763[1-2]|506(699|7[0-6][0-9]|77[0-8])|509\d{3}|504175|627780|636297|636368|65003[1-3]|6500(3[5-9]|4[0-9]|5[0-1])|6504(0[5-9]|[1-3][0-9])|650(4[8-9][0-9]|5[0-2][0-9]|53[0-8])|6505(4[1-9]|[5-8][0-9]|9[0-8])|6507(0[0-9]|1[0-8])|65072[0-7]|6509(0[1-9]|1[0-9]|20)|6516(5[2-9]|[6-7][0-9])|6550([0-1][0-9]|2[1-9]|[3-4][0-9]|5[0-8]))"
           );

        public readonly static CardBrandInfo Hipercard = new CardBrandInfo(
                CardBrandType.Hipercard,
                @"^(606282\d{10}(\d{3})?)|(3841\d{15})$"
           );

        public readonly static CardBrandInfo Hiper = new CardBrandInfo(
                CardBrandType.Hiper,
                @"^637095"
           );

        public readonly static CardBrandInfo Credz = new CardBrandInfo(
                CardBrandType.Credz,
                @"^636760"
           );

        public readonly static CardBrandInfo Banescard = new CardBrandInfo(
                CardBrandType.Banescard,
                @"^636117|^637473|^637470|^637472|^650725|^650046|^650591|^651668|^651679|^628028"
           );

        public readonly static CardBrandInfo Cabal = new CardBrandInfo(
                CardBrandType.Cabal,
                @"(60420[1-9]|6042[1-9][0-9]|6043[0-9]{2}|604400)"
           );

        public readonly static CardBrandInfo Sorocred = new CardBrandInfo(
                 CardBrandType.Sorocred,
                 @"^627892|^636414"
            );

        public readonly static CardBrandInfo Diners = new CardBrandInfo(
                  CardBrandType.Diners,
                 @"^3(0[0-5]|[68]\d)\d{11}$"
             );

        public readonly static CardBrandInfo Amex = new CardBrandInfo(
                 CardBrandType.Amex,
                @"^3[47]\d{13}$"
            );

        public readonly static CardBrandInfo Discover = new CardBrandInfo(
                  CardBrandType.Discover,
                 @"^6(?:011|5[0-9]{2})[0-9]{12}$"
             );

        public readonly static CardBrandInfo Jcb = new CardBrandInfo(
                  CardBrandType.Jcb,
                 @"(?:2131|1800|35\d{3})\d{11}"
             );
        public readonly static CardBrandInfo Aura = new CardBrandInfo(
                CardBrandType.Aura,
                @"^(5078\d{2})(\d{2})(\d{11})$"
             );

        public readonly static CardBrandInfo Maestro = new CardBrandInfo(
                 CardBrandType.Maestro,
                 @"^(?:5[0678]\d\d|6304|6390|67\d\d)\d{8,15}$"
             );

        public readonly static CardBrandInfo Visa = new CardBrandInfo(
                  CardBrandType.Visa,
                   @"^4\d{12}(\d{3})?$"
              );

        public readonly static CardBrandInfo Mastercard = new CardBrandInfo(
               CardBrandType.Mastercard,
                @"^(5[1-5]\d{4}|677189)\d{10}$"
           );

        public readonly static CardBrandInfo Mastercard2 = new CardBrandInfo(
               CardBrandType.Mastercard,
              @"^((5(([1-2]|[4-5])[0-9]{8}|0((1|6)([0-9]{7}))|3(0(4((0|[2-9])[0-9]{5})|([0-3]|[5-9])[0-9]{6})|[1-9][0-9]{7})))|((508116)\\d{4,10})|((502121)\\d{4,10})|((589916)\\d{4,10})|(2[0-9]{15})|(67[0-9]{14})|(506387)\\d{4,10})"
           );
    }
}
