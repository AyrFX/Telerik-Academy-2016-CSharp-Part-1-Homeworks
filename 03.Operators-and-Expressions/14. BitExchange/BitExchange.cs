using System;

class BitExchange
{
    public static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint mask, firstBit, secondBit;

        for (int i = 3; i <= 5; i++)
        {
            mask = 1;
            mask = mask << i;
            mask = mask & number;
            mask = mask >> i;
            firstBit = mask;

            mask = 1;
            mask = mask << i + 21;
            mask = mask & number;
            mask = mask >> i + 21;
            secondBit = mask;

            if (firstBit != secondBit)
            {
                mask = 1;
                mask = mask << i;
                if (secondBit == 1)
                {
                    number = mask | number;
                }
                else
                {
                    number = ~mask & number;
                }

                mask = 1;
                mask = mask << i + 21;
                if (firstBit == 1)
                {
                    number = mask | number;
                }
                else
                {
                    number = ~mask & number;
                }
            }
        }

        Console.WriteLine(number);
    }
}