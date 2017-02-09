using System;

class StringRepeater
{
    static void Main()
    {
        string text = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine(RepeatString(text, count));
    }

    static string RepeatString(string text, int count)
    {
        string repeatedString = string.Empty;

        for (int i = 0; i < count; i++)
        {
            repeatedString += text;
        }

        return repeatedString;
    }
}

