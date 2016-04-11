using System;

class NthBit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        byte position = byte.Parse(Console.ReadLine());
        ulong mask = 1;

        mask = mask << position;
        mask = mask & number;
        mask = mask >> position;

        Console.WriteLine(mask);
    }
}