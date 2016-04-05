using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object objectVariable = firstString + " " + secondString;
        string resultString = (string)objectVariable;
        Console.WriteLine(resultString);
    }
}