using System;

class BitModify
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        byte position = byte.Parse(Console.ReadLine());
        byte bitValue = byte.Parse(Console.ReadLine());
        ulong mask = 1;

        mask = mask << position;
        if (bitValue == 1)
        {
            mask = mask | number;
        }
        else
        {
            mask = ~mask & number;
        }
        Console.WriteLine(mask);
    }
}