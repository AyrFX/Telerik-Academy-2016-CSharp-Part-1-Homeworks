using System;

class OddOrEven
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber % 2 == 0)
        {
            Console.WriteLine("even " + inputNumber);
        }
        else
        {
            Console.WriteLine("odd " + inputNumber);
        }
    }
}
