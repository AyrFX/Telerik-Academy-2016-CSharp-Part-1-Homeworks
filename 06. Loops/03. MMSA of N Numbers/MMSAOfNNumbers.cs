using System;

class MMSAOfNNumbers
{
    public static void Main()
    {
        int numbers = int.Parse(Console.ReadLine());
        double min = double.MaxValue, max = double.MinValue, sum = 0;

        for (int i = 0; i < numbers; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());

            if (min > currentNumber)
            {
                min = currentNumber;
            }

            if (max < currentNumber)
            {
                max = currentNumber;
            }

            sum += currentNumber;
        }

        Console.WriteLine("min={0:0.00}", min);
        Console.WriteLine("max={0:0.00}", max);
        Console.WriteLine("sum={0:0.00}", sum);
        Console.WriteLine("avg={0:0.00}", sum / numbers);
    }
}