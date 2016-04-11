using System;

class ThirdDigit
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint thirdDigit = number / 100;
        thirdDigit = thirdDigit % 10;
        if (thirdDigit == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " + thirdDigit);
        }
    }
}