using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple.Example2.After.Features.Users.Menus
{
    public class UserInfoMenu
    {
        public static void Display(User userToDisplay)
        {
            Console.WriteLine($"Username: {userToDisplay.Username}");
        }
    }
}
