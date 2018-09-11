using System;

namespace SingleResponsibilityPrinciple.Example2.After.Features.Users.Menus
{
    public class CreateUserMenu
    {
        public static string Display()
        {
            Console.Write("Create a Username: ");
            return Console.ReadLine();
        }
    }
}
