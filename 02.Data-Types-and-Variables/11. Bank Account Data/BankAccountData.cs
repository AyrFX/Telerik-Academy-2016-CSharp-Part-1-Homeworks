using System;

class BankAccountData
{
    static void Main()
    {
        string holderNames = "Pesho Goshev Toshev";
        decimal balance = 35.12m;
        string bankName = "The Best Bank of the World";
        string ibanNumber = "BG34-TBOW-0000-2342-5674-94";
        ulong firstCardNumber = 123456790;
        ulong secondCardNumber = 0987654321;
        ulong thirdCardNumber = 1029384756;
        Console.WriteLine("Holder names: " + holderNames);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Bank: " + bankName);
        Console.WriteLine("IBAN Number: " + ibanNumber);
        Console.WriteLine("First credit card number: " + firstCardNumber);
        Console.WriteLine("Second credit card number: " + secondCardNumber);
        Console.WriteLine("Third credit card number: " + thirdCardNumber);
    }
}
