using System;

class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            Console.WriteLine("false");
            return;
        }

        int endNumberToCheck = (int)Math.Sqrt(number) + 1;
        for (int i = 2; i < endNumberToCheck; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine("false");
                return;
            }
        }
        Console.WriteLine("true");
    }
}