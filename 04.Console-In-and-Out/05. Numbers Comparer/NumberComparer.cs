using System;

class NumberComparer
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        if (numberA > numberB)
        {
            Console.WriteLine(numberA);
        }
        else
        {
            Console.WriteLine(numberB);
        }
    }
}
