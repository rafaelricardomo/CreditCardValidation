# CreditCardValidation
Validação cartão de crédito

--------------------------------------------
Bandeiras
--------------------------------------------
Elo
Hipercard
Hiper
Credz
Banescard
Sorocred
Cabal
Diners
Amex
Discover
Jcb
Aura
Maestro
Visa
Mastercard
--------------------------------------------

Validação de número do cartão
--------------------------------------------
var card = "869906133058105";
var valid = CreditCardValidationHelper.IsNumberValid(card);
Console.WriteLine(valid); //True
--------------------------------------------

Validação de bandeira do cartão
--------------------------------------------
var card = "869906133058105";
 var brand = CreditCardValidationHelper.GetBrand(card);
Console.WriteLine(brand); //"Hipercard"
--------------------------------------------
