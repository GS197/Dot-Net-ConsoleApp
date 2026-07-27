using System;

class Program
{
    static void Main()
    {
        StartApplication();

        Console.ReadLine();
    }

    static void StartApplication()
    {
        Login();

        Console.WriteLine("Application Started");
    }

    static void Login()
    {
        ValidateUser();

        Console.WriteLine("User Logged In");
    }

    static void ValidateUser()
    {
        Console.WriteLine("Validating User");
    }
}