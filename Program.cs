using System;

class BubbliciousNumbers
{
    static void Main()
    {
        int count = 0;
        for (int i = 2; i <= 100000; i++)
        {
            if (IsPrime(i) && EndsInB(i))
            {
                count++;
            }
        }
        Console.WriteLine($"Number of Bubblicious Numbers between 1 and 100,000: {count}");
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static bool EndsInB(int number)
    {
        string hex = number.ToString("X");
        return hex.EndsWith("B");
    }
}