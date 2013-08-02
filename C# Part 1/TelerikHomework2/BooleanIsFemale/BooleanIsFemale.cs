using System;

class BooleanIsFemale
{
    static void Main()
    {
        string gender;
        Console.WriteLine("Please enter true or false for the question .Are you a female??");
        gender=Console.ReadLine();
        bool isFemale;
        if (bool.TryParse(gender, out isFemale))
        {
            if (isFemale)
            {
                Console.WriteLine("You are a female!!");
            }
            else
            {
                Console.WriteLine("You are a male!!");
            }
        }
        else
        {
            Console.WriteLine("Please enter true or false");
        }
    }
}
