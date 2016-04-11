using System;

class BitSwap
{
    public static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        byte firstSequenceBegin = byte.Parse(Console.ReadLine());
        byte secondSequenceBegin = byte.Parse(Console.ReadLine());
        byte sequencesLength = byte.Parse(Console.ReadLine());
        uint mask, firstBit, secondBit;

        byte sequencesDifference;
        sbyte shiftDirection;

        if (firstSequenceBegin < secondSequenceBegin)
        {
            sequencesDifference = (byte)(secondSequenceBegin - firstSequenceBegin);
            shiftDirection = 1;
        }
        else
        {
            sequencesDifference = (byte)(firstSequenceBegin - secondSequenceBegin);
            shiftDirection = -1;
        }

        for (int i = firstSequenceBegin; i <= firstSequenceBegin + sequencesLength - 1; i++)
        {
            mask = 1;
            mask = mask << i;
            mask = mask & number;
            mask = mask >> i;
            firstBit = mask;

            mask = 1;
            mask = mask << i + (sequencesDifference * shiftDirection);
            mask = mask & number;
            mask = mask >> i + (sequencesDifference * shiftDirection);
            secondBit = mask;

            if (firstBit != secondBit)
            {
                mask = 1;
                mask = mask << i;
                if (secondBit == 1)
                {
                    number = mask | number;
                }
                else
                {
                    number = ~mask & number;
                }

                mask = 1;
                mask = mask << i + (sequencesDifference * shiftDirection);
                if (firstBit == 1)
                {
                    number = mask | number;
                }
                else
                {
                    number = ~mask & number;
                }
            }
        }

        Console.WriteLine(number);
    }
}