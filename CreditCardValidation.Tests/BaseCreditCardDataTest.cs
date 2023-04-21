namespace CreditCardValidation.Tests
{
    public class BaseCreditCardDataTest
    {
        // Test cards
        public string[] cards = new string[] {
            "378282246310005",     // American Express
            "371449635398431",     // American Express
            "5078601870000127985", // Aura
            "5078601800003247449", // Aura
            "30569309025904",      // Diners Club
            "38520000023237",      // Diners Club
            "6011111111111117",    // Discover
            "6362970000457013",    // Elo
            "6062825624254001",    // Hipercard
            "5555555555554444",    // MasterCard
            "5105105105105100",    // MasterCard
            "6759649826438453",    // Maestro
            "6799990100000000019", // Maestro
            "4111111111111111",    // Visa
            "4012888888881881",    // Visa
        };

        // Test cards v2
        public string[] cardsV2 = new string[] {
                "5277696455399733",    //mastercard
                "5448280000000007",    //mastercard
                "2223000148400010", // mastercard
                "2223020000000005", // mastercard
                "4761120000000148",      // visa
                "4235647728025682",      // visa
                "6062825624254001",    // hipercard
                "6370950847866501",    // hiper
                "36490101441625",    // Diners
                "3569990012290937",    // JCB
                "3572000100200142753",    // JCB
                "6367600001405019",    // credz
                "4389351648020055", // elo
                "371341553758128",    // amex
                "6042034400069940",    // cabal
                "6364142000000122",    // sorocred                
                "6031828795629272", // banescard
                "6280281038975334", // credsystem
                "4895370010000005",    // visa
                "4824810010000006",    // visa
                "2223000250000004",    // mastercard
                "5204970000000007",    // mastercard
        };
    }
}
