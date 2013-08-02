using System;

class SimpleTasks
{
    static void Menu()
    {
        Console.WriteLine("Choose one of the simple tasks by entering its number.");
        Console.WriteLine("1.Reverse the digits of a number.");
        Console.WriteLine("2.Calculates the average of a sequence of integers");
        Console.WriteLine("3.Solves a linear equation a * x + b = 0");
        Console.WriteLine("---------------------------------------------------------");
    }

    static void Input()
    {
        int choice = int.Parse(Console.ReadLine());
        if (choice <= 0 || choice > 3)
        {
            Console.WriteLine("Invalid input.Try again.");
            Input();
        }
        if (choice == 1)
        {
            Console.WriteLine("You have choosen reversing please enter a positive number.");
            int number = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
            }
            while(number < 0);
            Console.WriteLine("The reversed number is : {0}",Reversing(number));
        }
        if (choice == 2)
        {
           
            Console.WriteLine("You have choosen averege of sequance please enter the array lenght and array.");
            int n = 0;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n == 0);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The averege of the array is: {0}",AveregeOfSequence(arr));
        }
        if (choice == 3)
        {
            Console.WriteLine("You have chosen the equation: enter a >0 and b");
            int a = 0, b = 0;
            do
            {
                a = int.Parse(Console.ReadLine());
            } while (a == 0);
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("The answer is: {0}",Linear(a,b));
        }
            
    }
    static int Reversing(int number)
    {
        int newNumber = 0;
        while (number != 0)
        {
            newNumber *= 10;
            newNumber += (number % 10);
            number /= 10;
        }
        return newNumber;
    }
    static int AveregeOfSequence(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        int result = sum / array.Length;
        return result;
    }
    static double Linear(double a, double b)
    {
        double result = (-b) / a;
        return result;
    }
    static void Main()
    {
        Menu();
        Input();
    }
}

