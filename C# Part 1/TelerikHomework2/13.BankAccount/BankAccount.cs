using System;

class BankAccount
{
    static void Main()
    {
        string firstName = ("Dumbo");
        string secondName = ("the big eared");
        string thirdName = ("Elephant");
        decimal moneyBalance = 1000;
        string bankName = ("Crazy Africa");
        string IBAN = ("BG-3219371298987");
        int BICCode = 3342;
        int firstCreditCardNumber = 11200, secondCreditCardNumber = 21381, thirdCreditCardNumber = 21731;
        Console.WriteLine("Mrs {0} {1} {2}, has an account in {3},with money balance of-{4} leva ,his IBAN is {5}"
            ,firstName,secondName,thirdName,bankName,moneyBalance,IBAN);
        Console.WriteLine("He also has three credit cards with this numbers {0}, {1}, {2}"
            ,firstCreditCardNumber,secondCreditCardNumber,thirdCreditCardNumber);
    }
}

