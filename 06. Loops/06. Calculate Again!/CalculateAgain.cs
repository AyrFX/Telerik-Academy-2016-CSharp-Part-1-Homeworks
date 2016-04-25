using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        short numberN = short.Parse(Console.ReadLine());
        short numberK = short.Parse(Console.ReadLine());
        BigInteger factorialN = 1, factorialK = 1;
        short controlVar = Math.Max(numberN, numberK);

        for (int i = 1; i <= controlVar; i++)
        {
            if (i <= numberN)
            {
                factorialN *= i;
            }
            if (i <= numberK)
            {
                factorialK *= i;
            }

        }

        Console.WriteLine("{0}", factorialN / factorialK);
    }
}