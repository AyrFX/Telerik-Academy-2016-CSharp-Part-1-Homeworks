using System;

class ExchangeIfGreather
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double greaterNumber;
        if (numberA > numberB)
        {
            greaterNumber = numberA;
            numberA = numberB;
            numberB = greaterNumber;
        }
        Console.WriteLine("{0} {1}", numberA, numberB);
    }
}
