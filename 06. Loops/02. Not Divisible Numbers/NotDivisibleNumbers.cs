using System;

class NotDivisibleNumbers
{
    public static void Main()
    {
        int toNumber = int.Parse(Console.ReadLine());
        string result = "";

        for (int i = 1; i <= toNumber; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                if (result != "")
                {
                    result += " ";
                }

                result += i.ToString();
            }
        }
        Console.Write(result);
    }
}