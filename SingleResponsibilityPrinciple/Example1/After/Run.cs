using SingleResponsibilityPrinciple.Example1.After.Features.InformationDisplays;
using SingleResponsibilityPrinciple.Example1.After.Features.Users.Menus;

namespace SingleResponsibilityPrinciple.Example1.After
{
    public class Run
    {
        public static void Operation()
        {
            var newUser = CreateUserMenu.Handle();
            DisplayUserMenu.Handle(newUser);
            Printer.ReadLine();
        }
    }
}
