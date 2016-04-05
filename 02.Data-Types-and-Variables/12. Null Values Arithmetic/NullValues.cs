using System;

class NullValues
{
    static void Main()
    {
        int? integerNumber = null;
        double? doubleNumber = null;
        Console.WriteLine(integerNumber);
        Console.WriteLine(doubleNumber);
        integerNumber += 5;
        doubleNumber += 0.12;
        Console.WriteLine(integerNumber);
        Console.WriteLine(doubleNumber);
        integerNumber = 5;
        doubleNumber = 0.12;
        Console.WriteLine(integerNumber);
        Console.WriteLine(doubleNumber);
    }
}
