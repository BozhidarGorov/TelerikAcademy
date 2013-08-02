using System;

class AreaOfTrapezoid
{
    static void Main()
    {
        double sideA = 5;
        double sideB = 10;
        double height = 4;
        double area = (((sideA + sideB)/ 2) * height);
        Console.WriteLine("The area of the trapezoid is {0}",area);
    }
}

