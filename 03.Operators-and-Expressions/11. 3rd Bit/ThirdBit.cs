using System;

class ThirdBit
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 1;

        mask = mask << 3;
        mask = mask & number;
        mask = mask >> 3;

        Console.WriteLine(mask);
    }
}