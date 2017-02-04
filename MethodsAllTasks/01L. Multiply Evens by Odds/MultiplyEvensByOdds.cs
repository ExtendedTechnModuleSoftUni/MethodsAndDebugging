using System;

class MultiplyEvensByOdds
{
    static void Main()
    {
        int inputNumbers = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMultipleOfEvensAndOdds(inputNumbers));
    }

    static long GetMultipleOfEvensAndOdds(int inputNumbers)
    {
        int sumOdd = GetSumOfOddDigits(inputNumbers);
        int sumEven = GetSumOfEvenDigits(inputNumbers);
        long result = sumOdd * sumEven;

        return result;
    }

    private static int GetSumOfEvenDigits(int inputNumbers)
    {
        int sum = 0;
        inputNumbers = Math.Abs(inputNumbers);

        while (inputNumbers > 0)
        {
            int digit = inputNumbers % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }

            inputNumbers = inputNumbers / 10;
        }

        return sum;
    }

    static int GetSumOfOddDigits(int inputNumbers)
    {
        int sum = 0;
        inputNumbers = Math.Abs(inputNumbers);

        while (inputNumbers > 0)
        {
            int digit = inputNumbers % 10;
            if (digit % 2 != 0)
            {
                sum += digit;
            }

            inputNumbers = inputNumbers / 10;
        }

        return sum;
    }
}

