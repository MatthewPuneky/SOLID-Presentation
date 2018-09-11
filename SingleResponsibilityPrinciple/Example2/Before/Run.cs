using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple.Example2.Before
{
    public class Run
    {
        public static void Operation()
        {
            var newUser = new User();
            var userHasProvidedValidUsername = false;

            while (!userHasProvidedValidUsername)
            {
                Console.Write("Create a Username: ");
                var userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    userHasProvidedValidUsername = false;
                    Console.WriteLine("Username cannot be empty");
                }
                else if (userInput.Equals("Admin"))
                {
                    userHasProvidedValidUsername = false;
                    Console.WriteLine("Cannot user the username of Admin");
                }
                else
                {
                    userHasProvidedValidUsername = true;
                    newUser.Username = userInput;
                }
            }

            Console.WriteLine("Username Accepted");

            Console.WriteLine($"Username: {newUser.Username}");
        }
    }

    public class User
    {
        public string Username { get; set; }
    }
}
