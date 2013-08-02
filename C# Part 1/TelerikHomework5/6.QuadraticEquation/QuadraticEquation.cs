using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter a ,b ,c for the Equation aX^2+bX+c=0");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double X1, X2;
        double descriminanta = b * b - 4 * a * c;
        if (descriminanta == 0)
        {
            X1 = (-Math.Sqrt(c) / Math.Sqrt(a));
            Console.WriteLine("We have only one real root = {0}", X1);
        }
        if (descriminanta < 0)
        {
            Console.WriteLine("We don't have real roots");
        }
        if (descriminanta > 0)
        {
            X1 = (-b + Math.Sqrt(descriminanta)) / (2 * a);
            X2 = (-b - Math.Sqrt(descriminanta)) / (2 * a);
            Console.WriteLine("We have 2 real roots {0} \t {1}", X1, X2);
        }
    }
}

