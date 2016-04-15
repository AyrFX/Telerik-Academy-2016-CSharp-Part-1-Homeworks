using System;

class Interval
{
    static void Main()
    {
        short numberM = short.Parse(Console.ReadLine());
        short numberN = short.Parse(Console.ReadLine());
        short count = 0;
        for(int i = Math.Min(numberM, numberN) + 1; i < Math.Max(numberM, numberN); i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}