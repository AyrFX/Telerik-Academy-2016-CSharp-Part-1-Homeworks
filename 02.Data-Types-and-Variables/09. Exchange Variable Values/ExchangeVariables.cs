using System;

class ExchangeVariables
{
    static void Main()
    {
        int a = 5, b = 10;
        Console.WriteLine("a = " + a + "; b = " + b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("a = " + a + "; b = " + b);
    }
}