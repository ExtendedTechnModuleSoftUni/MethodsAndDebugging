using System;
class TrickyStrings
{
    static void Main()
    {
        var delimiter = Console.ReadLine();
        var numberOfStrings = int.Parse(Console.ReadLine());//Wrong place of variables       
        var result = string.Empty;
        var currentString = string.Empty;
        
        for (int i = 0; i < numberOfStrings; i++)//Starting from "0", we dont need operator "=".
        {
            currentString = Console.ReadLine();//Operator "=" was unnecessary.
            if (i != numberOfStrings - 1)// id-else construction added. Checking for last string to be without operator.
            {
                result += currentString + delimiter;
            }
            else
            {
                result += currentString;
            }
        }
 
        Console.WriteLine(result);
    }
}