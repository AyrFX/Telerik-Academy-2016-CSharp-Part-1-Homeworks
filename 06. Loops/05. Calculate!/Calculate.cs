using System;

class Calculate
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        double numberX = double.Parse(Console.ReadLine());
        double sum = 0, currentFactorial = 1;

        for (int i = 1; i <= numberN; i++)
        {
            currentFactorial *= i;
            sum += currentFactorial / Math.Pow(numberX, i);
        }
        sum += 1;

        Console.WriteLine("{0:F5}", sum);
    }
}