namespace _11Е.Numbers_to_Words
{
    using System;

    class NumbersТоWords
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string numberToString = Console.ReadLine();
                int number = int.Parse(numberToString);

                if (number > 999)
                {
                    Console.Write("too large");
                }
                else if (number < -999)
                {
                    Console.Write("too small");
                }
                else if (numberToString.Length < 3)
                {
                    continue;
                }
                else
                {
                    Letterize(number);
                }

                Console.WriteLine();
            }
        }

        static void Letterize(int number)
        {
            string numberToText = string.Empty;

            GetHundredsToText(number, numberToText);
            GetLastTwoDigitsToText(number, numberToText);
        }

        static void GetLastTwoDigitsToText(int number, string numberToText)
        {
            int lastTwoDigits = Math.Abs(number % 100);

            if (lastTwoDigits < 10)
            {
                GetLessThanTen(lastTwoDigits, numberToText, number);
            }
            else if (lastTwoDigits >= 10 && lastTwoDigits < 20)
            {
                GetMoreThanTenAndLessThanTwenty(lastTwoDigits, numberToText, number);
            }
            else
            {
                GetMoreThanTwenty(lastTwoDigits, numberToText, number);
            }
        }

        static void GetMoreThanTwenty(int lastTwoDigits, string numberToText, int number)
        {
            int lastDigit = number % 10;
            int secondDigit = (number / 10) % 10;
            int firstDigit = number / 100;

            switch (Math.Abs(secondDigit))
            {
                case 2:
                    numberToText = " and twenty";
                    break;
                case 3:
                    numberToText = " and thirty";
                    break;
                case 4:
                    numberToText = " and forty";
                    break;
                case 5:
                    numberToText = " and fifty";
                    break;
                case 6:
                    numberToText = " and sixty";
                    break;
                case 7:
                    numberToText = " and seventy";
                    break;
                case 8:
                    numberToText = " and eighty";
                    break;
                case 9:
                    numberToText = " and ninety";
                    break;
            }

            Console.Write(numberToText);



            if (lastDigit != 0)
            {
                switch (Math.Abs(lastDigit))
                {
                    case 1:
                        numberToText = " one";
                        break;
                    case 2:
                        numberToText = " two";
                        break;
                    case 3:
                        numberToText = " three";
                        break;
                    case 4:
                        numberToText = " four";
                        break;
                    case 5:
                        numberToText = " five";
                        break;
                    case 6:
                        numberToText = " six";
                        break;
                    case 7:
                        numberToText = " seven";
                        break;
                    case 8:
                        numberToText = " eight";
                        break;
                    case 9:
                        numberToText = " nine";
                        break;
                }

                Console.Write(numberToText);
            }
        }

        static void GetMoreThanTenAndLessThanTwenty(int lastTwoDigits, string numberToText, int number)
        {
            switch (lastTwoDigits)
            {
                case 10:
                    numberToText = " and ten";
                    break;
                case 11:
                    numberToText = " and eleven";
                    break;
                case 12:
                    numberToText = " and twelve";
                    break;
                case 13:
                    numberToText = " and thirteen";
                    break;
                case 14:
                    numberToText = " and fourteen";
                    break;
                case 15:
                    numberToText = " and fifteen";
                    break;
                case 16:
                    numberToText = " and sixteen";
                    break;
                case 17:
                    numberToText = " and seventeen";
                    break;
                case 18:
                    numberToText = " and eighteen";
                    break;
                case 19:
                    numberToText = " and nineteen";
                    break;
            }

            Console.Write(numberToText);
        }

        static void GetLessThanTen(int lastTwoDigits, string numberToText, int number)
        {
            switch (lastTwoDigits)
            {
                case 1:
                    numberToText = " and one";
                    break;
                case 2:
                    numberToText = " and two";
                    break;
                case 3:
                    numberToText = " and three";
                    break;
                case 4:
                    numberToText = " and four";
                    break;
                case 5:
                    numberToText = " and five";
                    break;
                case 6:
                    numberToText = " and six";
                    break;
                case 7:
                    numberToText = " and seven";
                    break;
                case 8:
                    numberToText = " and eight";
                    break;
                case 9:
                    numberToText = " and nine";
                    break;
            }

            Console.Write(numberToText);
        }

        static void GetHundredsToText(int number, string numberToText)
        {
            int hundreds = number / 100;
            if (hundreds != 0)
            {
                switch (Math.Abs(hundreds))
                {
                    case 1:
                        numberToText += "one-hundred";
                        break;
                    case 2:
                        numberToText += "two-hundred";
                        break;
                    case 3:
                        numberToText += "three-hundred";
                        break;
                    case 4:
                        numberToText += "four-hundred";
                        break;
                    case 5:
                        numberToText += "five-hundred";
                        break;
                    case 6:
                        numberToText += "six-hundred";
                        break;
                    case 7:
                        numberToText += "seven-hundred";
                        break;
                    case 8:
                        numberToText += "eight-hundred";
                        break;
                    case 9:
                        numberToText += "nine-hundred";
                        break;
                }

                if (hundreds < 0)
                {
                    Console.Write("minus " + numberToText);
                }
                else
                {
                    Console.Write(numberToText);
                }
            }
        }
    }
}
