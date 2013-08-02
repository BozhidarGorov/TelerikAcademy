using System;

class Circle
{
    static void Main()
    {
        string _radius = Console.ReadLine();
        double radius;
        double.TryParse(_radius,out radius);
        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine("Perimeter {0}",perimeter);
        Console.WriteLine("Area {0}", area);
    }
}

