using SingleResponsibilityPrinciple.Example1.After.Features.InformationDisplays;

namespace SingleResponsibilityPrinciple.Example1.After.Features.Users.Menus
{
    public class CreateUserMenu
    {
        private static void RequestInput()
        {
            Printer.Print("Create a new Username: ");
        }

        private static CreateUserRequest GetRequestFromUserInput()
        {
            var validator = new CreateUserRequestValidator();

            while (true)
            {
                RequestInput();
                var userInput = Printer.ReadLine();

                var request = new CreateUserRequest { Username = userInput };
                var validationResponse = validator.Validate(request);

                if (validationResponse.IsValid == false)
                {
                    validationResponse.ErrorMessages.ForEach(Printer.PrintLine);
                    continue;
                }

                return request;
            }
        }

        public static User Handle()
        {
            var request = GetRequestFromUserInput();
            var handler = new CreateUserRequestHandler();
            var response = handler.Handle(request);

            return response;
        }
    }
}