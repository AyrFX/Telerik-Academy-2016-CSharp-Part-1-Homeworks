using System;

class NumbersFromOneToN
{
    public static void Main()
    {
        int toNumber = int.Parse(Console.ReadLine());

        for (int i = 1; i <= toNumber; i++)
        {
            Console.Write(i);
            if (i < toNumber)
            {
                Console.Write(" ");
            }
        }
    }
}