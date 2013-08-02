using System;

class PrintMyAge
{
    static void Main()
    {
        string year;
        year = Console.ReadLine();
        int result;
        if (int.TryParse(year, out result)) 
        {
            Console.WriteLine(result + 10);
        }
        else
        {
            Console.WriteLine("You haven't entered an integer");
        }
    }
}

