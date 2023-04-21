using System.Collections.Generic;

namespace CreditCardValidation
{
    public struct CardBrandOptions
    {
        public readonly static List<CardBrandInfo> CardBrandsInfos = new List<CardBrandInfo>()
        {
           CardBrandInfo.Elo,
           CardBrandInfo.Elo2,
           CardBrandInfo.Hipercard,
           CardBrandInfo.Hiper,
           CardBrandInfo.Credz,
            CardBrandInfo.Banescard,
           CardBrandInfo.Cabal,
           CardBrandInfo.Sorocred,
            CardBrandInfo.Diners,
           CardBrandInfo.Amex,
            CardBrandInfo.Discover,
            CardBrandInfo.Jcb,
            CardBrandInfo.Aura,
            CardBrandInfo.Maestro,
            CardBrandInfo.Visa,
            CardBrandInfo.Mastercard,
            CardBrandInfo.Mastercard2,
        };


    }
}
