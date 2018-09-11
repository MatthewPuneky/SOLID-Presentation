using System.Linq;
using SingleResponsibilityPrinciple.Example1.After.Common.Validation;

namespace SingleResponsibilityPrinciple.Example1.After.Features.Users
{
    public class CreateUserRequest
    {
        public string Username { get; set; }
    }

    public class CreateUserRequestHandler
    {
        public User Handle(CreateUserRequest message)
        {
            var response = new User
            {
                Username = message.Username,
            };

            return response;
        }
    }

    public class CreateUserRequestValidator
    {
        public ValidationResponse Validate(CreateUserRequest message)
        {
            var response = new ValidationResponse();

            if (string.IsNullOrEmpty(message.Username))
            {
                response.ErrorMessages.Add("Username cannot be empty");
            }
            else if (message.Username.Equals("Admin"))
            {
                response.ErrorMessages.Add("Cannot use the username of Admin");
            }

            if (!response.ErrorMessages.Any())
            {
                response.IsValid = true;
            }

            return response;
        }
    }
}
