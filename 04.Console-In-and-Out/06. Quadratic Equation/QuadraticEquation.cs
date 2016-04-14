using System;

class QuadraticEquation
{
    static void Main()
    {
        double coefficientA = double.Parse(Console.ReadLine());
        double coefficientB = double.Parse(Console.ReadLine());
        double coefficientC = double.Parse(Console.ReadLine());
        double discriminant = Math.Pow(coefficientB, 2) - (4 * coefficientA * coefficientC);
        double root;
        if (discriminant > 0)
        {
            root = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
            double secondRoot = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
            if (root < secondRoot)
            {
                Console.WriteLine("{0:0.00}", root);
                Console.WriteLine("{0:0.00}", secondRoot);
            }
            else
            {
                Console.WriteLine("{0:0.00}", secondRoot);
                Console.WriteLine("{0:0.00}", root);
            }
        }
        else if (discriminant == 0)
        {
            root = (-coefficientB) / (2 * coefficientA);
            Console.WriteLine("{0:0.00}", root);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}
