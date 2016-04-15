using System;

class SumOfN
{
    static void Main()
    {
        byte count = byte.Parse(Console.ReadLine());
        double result = 0;
        for(int i = 0; i < count; i++)
        {
            result += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(result);
    }
}