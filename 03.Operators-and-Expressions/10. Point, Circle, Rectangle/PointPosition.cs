using System;

class PointPosition
{
    static void Main()
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        const double rectangleTop = 1;
        const double rectangleLeft = -1;
        const double rectangleRight = 5;
        const double rectangleBotton = -1;

        double distance = Math.Sqrt(Math.Abs(pointX - 1) * Math.Abs(pointX - 1) + Math.Abs(pointY - 1) * Math.Abs(pointY - 1));
        if (distance > 1.5)
        {
            Console.Write("outside circle ");
        }
        else
        {
            Console.Write("inside circle ");
        }

        if (pointX >= rectangleLeft && pointX <= rectangleRight && pointY <= rectangleTop && pointY >= rectangleBotton)
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }
    }
}