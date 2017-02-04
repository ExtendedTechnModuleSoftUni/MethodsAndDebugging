using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double oldPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = CalcPriceDifferences(oldPrice, currentPrice);
            bool isDifference = CheckingForDifferences(difference, significanceThreshold);
            string outputMessage = GetOutputMessage(currentPrice, oldPrice, difference, isDifference);

            Console.WriteLine(outputMessage);

            oldPrice = currentPrice;
        }
    }

    static string GetOutputMessage(double currentPrice, double oldPrice, double difference, bool isDifference)
    {
        string message = "";

        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", oldPrice, currentPrice, ((difference * 100)));
        }
        else if (isDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", oldPrice, currentPrice, ((difference) * 100));
        }
        else if (isDifference && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", oldPrice, currentPrice, ((difference) * 100));
        }

        return message;
    }

    static bool CheckingForDifferences(double difference, double significanceThreshold)
    {
        if (Math.Abs(difference) >= significanceThreshold)
        {
            return true;
        }

        return false;
    }

    static double CalcPriceDifferences(double oldPrice, double currentPrice)
    {
        double differenceInPercentages = (currentPrice - oldPrice) / oldPrice;
        return differenceInPercentages;
    }
}
