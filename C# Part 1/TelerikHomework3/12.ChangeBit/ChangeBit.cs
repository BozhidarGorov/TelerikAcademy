using System;

class ChangeBit
{
    static void Main()
    {
        string number, position,value;
        number = Console.ReadLine();
        position = Console.ReadLine();
        Console.WriteLine("Enter value 1 or 0");
        value = Console.ReadLine();
        int _position;
        int intToExtractFrom;
        int mask;
        int.TryParse(number, out intToExtractFrom);
        int.TryParse(position, out _position);
        int.TryParse(value, out mask);
        Console.WriteLine("Number in bit form!");
        Console.WriteLine(Convert.ToString(intToExtractFrom, 2).PadLeft(10, '0'));
        Console.WriteLine("Mask!");
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(10, '0'));
        if (mask == 0)
        {
            mask = 1;
            mask = mask << _position;
            Console.WriteLine("Mask after shift!");
            Console.WriteLine(Convert.ToString(~mask, 2).PadLeft(10, '0'));
            Console.WriteLine("Number after replacmenent!");
            Console.WriteLine(Convert.ToString((intToExtractFrom & ~mask), 2).PadLeft(10, '0'));
        }
        else
        {
            mask = mask << _position;
            Console.WriteLine("Mask after shift!");
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(10, '0'));
            Console.WriteLine("Number after replacmenent!");
            Console.WriteLine(Convert.ToString((intToExtractFrom | mask), 2).PadLeft(10, '0'));
        }
    }
}

