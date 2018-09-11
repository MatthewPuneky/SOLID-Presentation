using SingleResponsibilityPrinciple.Example2.After.Features.Users;
using SingleResponsibilityPrinciple.Example2.After.Features.Users.Menus;

namespace SingleResponsibilityPrinciple.Example2.After
{
    public class Run
    {
        public static void Operation()
        {
            var user = CreateUserHandler.Handle();
            UserInfoMenu.Display(user);
        }
    }
}
