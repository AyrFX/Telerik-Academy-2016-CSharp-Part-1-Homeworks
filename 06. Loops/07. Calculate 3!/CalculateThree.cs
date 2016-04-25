using System;
using System.Numerics;

class CalculateThree
{
    static void Main()
    {
        short numberN = short.Parse(Console.ReadLine());
        short numberK = short.Parse(Console.ReadLine());
        BigInteger factorialN = 1, factorialK = 1, factorialDifference = 1;
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
            if (i <= numberN - numberK)
            {
                factorialDifference *= i;
            }

        }

        Console.WriteLine("{0}", factorialN / (factorialK * factorialDifference));
    }
}