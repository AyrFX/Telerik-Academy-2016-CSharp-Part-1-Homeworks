using System;

class FibonacciNumbers
{
    static void Main()
    {
        byte numbersTo = byte.Parse(Console.ReadLine());
        long firstNumber = 0, secondNumber = 1, currentNumber;
        if (numbersTo == 1)
        {
            Console.WriteLine("0");
        }
        else if (numbersTo == 2)
        {
            Console.WriteLine("0, 1");
        }
        else
        {
            Console.Write("0, 1");
            for (int i = 3; i <= numbersTo; i++)
            {
                Console.Write(", ");
                currentNumber = firstNumber + secondNumber;
                Console.Write(currentNumber);
                firstNumber = secondNumber;
                secondNumber = currentNumber;
            }
            Console.WriteLine("");
        }
    }
}