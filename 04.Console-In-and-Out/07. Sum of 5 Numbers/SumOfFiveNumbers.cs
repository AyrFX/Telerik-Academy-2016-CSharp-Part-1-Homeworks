using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        short result = short.Parse(Console.ReadLine());
        result += short.Parse(Console.ReadLine());
        result += short.Parse(Console.ReadLine());
        result += short.Parse(Console.ReadLine());
        result += short.Parse(Console.ReadLine());
        Console.WriteLine(result);
    }
}