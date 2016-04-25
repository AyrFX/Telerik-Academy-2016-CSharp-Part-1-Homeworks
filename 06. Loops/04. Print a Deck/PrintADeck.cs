using System;

class PrintADeck
{
    public static void Main()
    {
        string printToSign = Console.ReadLine();
        for (byte i = 2; i <= SignToNumber(printToSign); i++)
        {
            for (byte j = 0; j < 4; j++)
            {
                Console.Write("{0} of {1}", NumberToSign(i), GetSuit(j));

                if (j != 3)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }

    public static byte SignToNumber(string sign)
    {
        byte number;
        switch (sign)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
                number = Convert.ToByte(sign);
                break;
            case "J":
                number = 11;
                break;
            case "Q":
                number = 12;
                break;
            case "K":
                number = 13;
                break;
            case "A":
                number = 14;
                break;
            default:
                number = 0;
                break;
        }
        return number;
    }

    public static string NumberToSign(byte number)
    {
        string sign;
        switch (number)
        {
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                sign = number.ToString();
                break;
            case 11:
                sign = "J";
                break;
            case 12:
                sign = "Q";
                break;
            case 13:
                sign = "K";
                break;
            case 14:
                sign = "A";
                break;
            default:
                sign = "";
                break;
        }
        return sign;
    }

    public static string GetSuit(byte suitNumber)
    {
        switch (suitNumber)
        {
            case 0:
                return "spades";
            case 1:
                return "clubs";
            case 2:
                return "hearts";
            case 3:
                return "diamonds";
        }
        return "";
    }
}