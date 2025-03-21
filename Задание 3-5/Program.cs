using System;

class Program
{
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;

        return GCD(b, a % b);
    }

    static void Main()
    {
        int num1 = 56;
        int num2 = 98;

        int gcd = GCD(num1, num2);
        Console.WriteLine($"Наибольший общий делитель {num1} и {num2} равен {gcd}");
    }
}