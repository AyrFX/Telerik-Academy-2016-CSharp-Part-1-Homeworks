using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int doubleN = numberN * 2;
        int numberNPlusOne = numberN + 1;
        BigInteger factorialN = 1, factorialDoubleN = 1, factorialNumberNPlusOne = 1;

        for (int i = 1; i <= doubleN; i++)
        {
            if (i <= numberN)
            {
                factorialN *= i;
            }
            if (i <= doubleN)
            {
                factorialDoubleN *= i;
            }
            if (i <= numberNPlusOne)
            {
                factorialNumberNPlusOne *= i;
            }

        }

        Console.WriteLine("{0}", factorialDoubleN / (factorialNumberNPlusOne * factorialN));
    }
}