using System;

class BiggestOfFive
{
    static void Main()
    {
        double numberA = double.Parse(Console.ReadLine());
        double numberB = double.Parse(Console.ReadLine());
        double numberC = double.Parse(Console.ReadLine());
        double numberD = double.Parse(Console.ReadLine());
        double numberE = double.Parse(Console.ReadLine());
        if (numberA >= numberB && numberA >= numberC && numberA >= numberD && numberA >= numberE)
        {
            Console.WriteLine(numberA);
        }
        else if (numberB >= numberA && numberB >= numberC && numberB >= numberD && numberB >= numberE)
        {
            Console.WriteLine(numberB);
        }
        else if (numberC >= numberB && numberC >= numberA && numberC >= numberD && numberC >= numberE)
        {
            Console.WriteLine(numberC);
        }
        else if (numberD >= numberB && numberD >= numberC && numberD >= numberA && numberD >= numberE)
        {
            Console.WriteLine(numberD);
        }
        else if (numberE >= numberB && numberE >= numberC && numberE >= numberD && numberE >= numberA)
        {
            Console.WriteLine(numberE);
        }
    }
}