using System;

class NumbersToN
{
    static void Main()
    {
        short numberTo = short.Parse(Console.ReadLine());
        for (int i = 1; i <= numberTo; i++)
        {
            Console.WriteLine(i);
        }
    }
}