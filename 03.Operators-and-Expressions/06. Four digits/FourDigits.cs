using System;

class FourDigits
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint firstDigit = number / 1000;
        firstDigit = firstDigit % 10;
        uint secondDigit = number / 100;
        secondDigit = secondDigit % 10;
        uint thirdDigit = number / 10;
        thirdDigit = thirdDigit % 10;
        uint fourthDigit = number % 10;

        uint result = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine(result);
        result = firstDigit + secondDigit * 10 + thirdDigit * 100 + fourthDigit * 1000;
        Console.WriteLine(result.ToString("D4"));
        result = fourthDigit * 1000 + firstDigit * 100 + secondDigit * 10 + thirdDigit;
        Console.WriteLine(result.ToString("D4"));
        result = firstDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + fourthDigit;
        Console.WriteLine(result.ToString("D4"));
    }
}