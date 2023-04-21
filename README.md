# CreditCardValidation
Validação cartão de crédito

--------------------------------------------
Bandeiras
--------------------------------------------

Elo
Hipercard
Hiper
Credz
Credsystem
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



exemplo para validação de número do cartão:

var card = "869906133058105";

var valid = CreditCardValidationHelper.IsNumberValid(card);

Console.WriteLine(valid); //True



exemplo para validação de bandeira do cartão:

var card = "869906133058105";

var brand = CreditCardValidationHelper.GetBrand(card);
 
Console.WriteLine(brand); //"Hipercard"

