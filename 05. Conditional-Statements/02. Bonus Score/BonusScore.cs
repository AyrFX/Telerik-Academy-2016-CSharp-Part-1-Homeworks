using System;

class BonusScore
{
    static void Main()
    {
        short score = short.Parse(Console.ReadLine());
        if (1 <= score && score <= 3)
        {
            score *= 10;
            Console.WriteLine(score);
        }
        else if (4 <= score && score <= 6)
        {
            score *= 100;
            Console.WriteLine(score);
        }
        else if (7 <= score && score <= 9)
            {
            score *= 1000;
            Console.WriteLine(score);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}