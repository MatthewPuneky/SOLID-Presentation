using System;
using SingleResponsibilityPrinciple.Example2.After.Features.Users.Menus;

namespace SingleResponsibilityPrinciple.Example2.After.Features.Users
{
    public class CreateUserHandler
    {
        public static User Handle()
        {
            while (true)
            {
                var userInput = CreateUserMenu.Display();

                if(CreateUserValidator.Validate(userInput))
                {
                    Console.WriteLine("Username Accepted");
                    return new User { Username = userInput };
                }
            }
        }
    }

    public class CreateUserValidator
    {
        public static bool Validate(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Username cannot be empty");
                return false;
            }

            if (userInput.Equals("Admin"))
            {
                Console.WriteLine("Cannot user the username of Admin");
                return false;
            }

            return true;
        }
    }
}
