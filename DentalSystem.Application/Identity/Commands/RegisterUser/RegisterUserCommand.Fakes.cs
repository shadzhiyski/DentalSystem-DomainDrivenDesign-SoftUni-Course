namespace DentalSystem.Application.Identity.Commands.CreateUser
{
    using Bogus;

    public class RegisterUserCommandFakes
    {
        public static class Data
        {
            public static RegisterUserCommand GetCommand()
                => new Faker<RegisterUserCommand>()
                    .RuleFor(u => u.Email, f => f.Internet.Email())
                    .RuleFor(u => u.Password, f => f.Lorem.Letter(10))
                    .RuleFor(u => u.FirstName, f => f.Name.FirstName())
                    .RuleFor(u => u.LastName, f => f.Name.LastName())
                    .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber("+#######"))
                    .Generate();
        }
    }
}
