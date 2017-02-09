using System;

class MinMethod
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        GetMin(firstNum, secondNum);

        int thirdNum = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Min(thirdNum, GetMin(firstNum, secondNum)));
    }

    static int GetMin(int firstNum, int secondNum)
    {
        int min = Math.Min(firstNum, secondNum);

        return min;
    }
}

