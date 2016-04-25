using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int numbersCount = numberN * numberN;
        for (int i = 1; i <= numberN; i++)
        {
            for (int j = i; j <= numberN + i - 1; j++)
            {
                Console.Write(j);
                if (j != numberN + i - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("");
        }
    }
}