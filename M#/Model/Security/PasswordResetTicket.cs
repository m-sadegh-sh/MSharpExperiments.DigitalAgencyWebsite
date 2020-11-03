using MSharp;

namespace Security
{
    public class PasswordResetTicket : EntityType
    {
        public PasswordResetTicket()
        {
            Schema("Security");

            Associate<User>("User")
                .Mandatory()
                .DatabaseIndex()
                .OnDelete(CascadeAction.CascadeDelete);

            DateTime("Date created")
                .Mandatory()
                .Default(cs("LocalTime.Now"));

            Bool("Is used")
                .Mandatory();

            Bool("Is expired")
                .Mandatory()
                .Calculated()
                .Getter("LocalTime.Now >= DateCreated.AddMinutes(GeneralSettings.Current.PasswordResetTicketExpiryMinutes)");
        }
    }
}