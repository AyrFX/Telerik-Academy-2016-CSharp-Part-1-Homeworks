using System;

class Age
{
    static void Main()
    {
        string birthdayAsString = Console.ReadLine();
        DateTime birthday;
        DateTime.TryParse(birthdayAsString, out birthday);
        DateTime currentDate = DateTime.Today;
        int age = currentDate.Year - birthday.Year;
        if (currentDate.AddYears(-age) < birthday)
        {
            age--;
        }
        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}