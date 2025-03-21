using System;

public static class MathUtilities
{
    public static int GCD(int a, int b)
    {
        if (a == 0) return b;
        if (b == 0) return a;

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

class Program
{
    static void Main()
    {
        int num1 = 48;
        int num2 = 18;

        int gcd = MathUtilities.GCD(num1, num2);
        Console.WriteLine($"Наибольший общий делитель {num1} и {num2} равен {gcd}");
    }
}