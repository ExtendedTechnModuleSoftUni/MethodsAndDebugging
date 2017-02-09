using System;

class Notifications
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string operation = Console.ReadLine();

            if (operation == "success")
            {
                string user = Console.ReadLine();
                string message = Console.ReadLine();

                Console.WriteLine(ShowSuccess(user, message));
            }
            else if (operation == "error")
            {
                string user = Console.ReadLine();
                int code = int.Parse(Console.ReadLine());

                Console.WriteLine(ShowError(user, code));
            }
            else
            {
                continue;
            }
        }
    }

    static string ShowError(string user, int code)
    {
        string error = string.Empty;
        if (code < 0)
        {
            error = ($"Error: Failed to execute {user}.\n==============================\nError Code: {code}.\nReason: Internal System Failure.");
        }
        else
        {
            error = ($"Error: Failed to execute {user}.\n==============================\nError Code: {code}.\nReason: Invalid Client Data.");
        }

        return error;
    }

    static string ShowSuccess(string user, string message)
    {
        string success = ($"Successfully executed {user}.\n==============================\nMessage: {message}.");

        return success;
    }
}

