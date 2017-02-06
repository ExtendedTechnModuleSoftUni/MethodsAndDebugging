using System;

class DebugMiningCoins
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string decrypted = "";
        float totalValue = 0;

        for (int i = 1; i <= n; i++)//Operator "=" is missing. Needs to be "<=n"
        {
            int number = int.Parse(Console.ReadLine());

            int digitOne = number / 100;
            int digitTwo = (number % 100) / 10;
            int digitThree = number % 10;

            totalValue += (digitOne + digitTwo + digitThree) / (float)n;
            int ASCIIcode = 0;

            if (i % 2 == 0)//Wrong condition statment was written "(i % 1 == 0)"
            {
                ASCIIcode = ((digitOne * 10) + digitThree) + digitTwo;
            }
            else
            {
                ASCIIcode = ((digitOne * 10) + digitThree) - digitTwo;//digit one needs to be multiplied with "10".
            }

            if ((ASCIIcode >= 65 && ASCIIcode <= 90)// wrond operator ">" instead of "<"
                || (ASCIIcode >= 97 && ASCIIcode <= 122))//additional operator "=" needed 
            {
                decrypted += (char)ASCIIcode;
            }
        }

        Console.WriteLine("Message: {0}", decrypted);
        Console.WriteLine("Value: {0:F7}", totalValue); // Needs to be 7 digits after the floating point
    }
}


