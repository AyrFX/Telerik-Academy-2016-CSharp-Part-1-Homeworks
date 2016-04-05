using System;

class Program
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber % 5 == 0 && inputNumber % 7 == 0)
        {
            Console.WriteLine("true " + inputNumber);
        }
        else
        {
            Console.WriteLine("false " + inputNumber);
        }
    }
}