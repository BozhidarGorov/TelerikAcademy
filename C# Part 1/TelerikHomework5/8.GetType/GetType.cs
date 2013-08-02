using System;

class GetType
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
        System.Globalization.CultureInfo.InvariantCulture;
        string inputString = Console.ReadLine();
        int inputInt;
        string result;
        double inputDouble;
        bool isInt = int.TryParse(inputString, out inputInt);
        bool isDouble = double.TryParse(inputString, out inputDouble) && !isInt;
        if (isInt)
        {
            result = "int";
        }
        else if (isDouble)
        {
            result = "double";
        }
        else
        {
            result = "string";
        }
        switch (result)
        {
            case "int": Console.WriteLine(inputInt + 1); break;
            case "double": Console.WriteLine(inputDouble + 1); break;
            case "string": Console.WriteLine(inputString + "*"); break;
        }
    }
}

