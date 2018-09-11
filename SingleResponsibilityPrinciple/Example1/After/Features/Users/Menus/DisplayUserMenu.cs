using SingleResponsibilityPrinciple.Example1.After.Features.InformationDisplays;

namespace SingleResponsibilityPrinciple.Example1.After.Features.Users.Menus
{
    public class DisplayUserMenu
    {
        private static void DisplayUserInformation(User user)
        {
            Printer.PrintLine($"Username: {user.Username}");
        }

        public static void Handle(User user)
        {
            DisplayUserInformation(user);
        }
    }
}
