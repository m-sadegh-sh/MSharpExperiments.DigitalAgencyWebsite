using MSharp;

namespace Security
{
    public class User : EntityType
    {
        public User()
        {
            Abstract();

            Schema("Security");

            String("First name")
                .Mandatory();

            String("Last name")
                .Mandatory();

            String("Name")
                .Calculated()
                .Getter("$\"{FirstName} {LastName}\"");

            String("Email", 100)
                .Mandatory()
                .Unique()
                .Accepts(TextPattern.EmailAddress);

            String("Password", 100)
                .HashPassword()
                .SaltProperty("Salt")
                .Accepts(TextPattern.Password);

            String("Salt");

            Bool("Is deactivated")
                .Mandatory();
        }
    }
}