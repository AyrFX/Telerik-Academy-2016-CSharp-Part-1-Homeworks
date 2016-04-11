using System;

class PointInACircle
{
    static void Main()
    {
        float pointX = float.Parse(Console.ReadLine());
        float pointY = float.Parse(Console.ReadLine());
        double distance = Math.Sqrt(pointX * pointX + pointY * pointY);
        if (distance <= 2)
        {
            Console.WriteLine("yes " + distance.ToString("F2"));
        }
        else
        {
            Console.WriteLine("no " + distance.ToString("F2"));
        }
    }
}