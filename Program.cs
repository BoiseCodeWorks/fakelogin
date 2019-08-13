using System;
using fakelogin.Models;

namespace fakelogin
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            App app = new App();
            app.AddUser(new User("Mark", "IHeartCode"));
            app.AddUser(new User("Jake", "MarkIsTheBest"));
            app.AddUser(new User("Kenny", "OMGYouKilledMe"));
            System.Console.WriteLine("Welcome, Please Login to continue: ");
            bool loggedOut = true;
            while (loggedOut)
            {
                Console.Write("Name:");
                string name = Console.ReadLine().ToLower();
                Console.Write("Password:");
                string pass = Console.ReadLine();

                if (app.Login(name, pass))
                {
                    System.Console.WriteLine($"Welcome {app.ActiveUser.Name}");
                    loggedOut = false;
                }
                else
                {
                    Console.Clear();
                    System.Console.WriteLine("Invalid Credentials");
                }
            }

        }
    }
}
