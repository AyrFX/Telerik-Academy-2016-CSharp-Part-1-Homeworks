using System;

class FormattingNumers
{
    static void Main()
    {
        int numberA = int.Parse(Console.ReadLine());
        float numberB = float.Parse(Console.ReadLine());
        float numberC = float.Parse(Console.ReadLine());
        Console.WriteLine("{0,-1:X3}|{1}|{2,3:0.00}|{3,-5:0.000}|", numberA, Convert.ToString(numberA, 2), numberA, numberB, numberC);
    }
}
