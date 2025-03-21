using System;

public static class StringExtensions
{
    public static string RemoveSpaces(this string str)
    {
        if (str == null)
        {
            throw new ArgumentNullException(nameof(str), "Строка не может быть null.");
        }

        return str.Replace(" ", "");
    }
}

class Program
{
    static void Main()
    {
        string input = "Это пример строки с пробелами.";
        string output = input.RemoveSpaces();

        Console.WriteLine($"Исходная строка: \"{input}\"");
        Console.WriteLine($"Строка без пробелов: \"{output}\"");
    }
}