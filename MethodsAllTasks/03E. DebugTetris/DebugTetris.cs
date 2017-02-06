using System;

class DebugTetris
{
    static void Main()
    {   // removing unnecessary "-1"
        int n = int.Parse(Console.ReadLine());
        string currentDirection = Console.ReadLine();

        while (currentDirection != "exit")
        {
            switch (currentDirection)
            {   // methods exchanged places 
                case "up":
                    Up(n);
                    break;
                case "right":
                    Right(n);
                    break;
                case "down":
                    Down(n);
                    break;
                case "left":
                    Left(n);
                    break;
            }

            currentDirection = Console.ReadLine();
        }
    }

    static void Left(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('.', n) + new string('*', n));
        }
        // wrong "i" iteration
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', 2 * n));
        }
        // wrong "i" declaration with "-1"
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('.', n) + new string('*', n));
        }
    }

    static void Right(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', n) + new string('.', n));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', 2 * n));
        }
        // wrong operator ">" instead of "<"
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', n) + new string('.', n));
        }
    }

    static void Up(int n)
    {
        for (int i = 0; i < n; i++)
        {   // wrong middle string "." instead of "*"
            Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', n * 3));
        }
    }

    static void Down(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', n * 3));
        }

        //n--;//unnecessary decrease "n" with "-1"
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('.', n) + new string('*', n) + new string('.', n));
        }
    }
}