using System;

class NthDigit
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        int index = int.Parse(Console.ReadLine());

        Console.WriteLine(FindNthDigit(number, index));
    }

    static int FindNthDigit(long number, int index)
    {
        int currentIndex = 1;
        int num = 0;

        while (number > 0)
        {
            if (currentIndex == index)
            {
                num = (int)number % 10;
                break;
            }

            currentIndex++;
            number = number / 10;
        }

        return num;
    }
}

