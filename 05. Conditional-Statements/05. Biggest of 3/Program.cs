using System;

class Program
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());
        if (numberA > numberB && numberA > numberC)
        {
            Console.WriteLine(numberA);
        }
        else if (numberB > numberA && numberB > numberC)
        {
            Console.WriteLine(numberB);
        }
        else
        {
            Console.WriteLine(numberC);
        }
    }
}