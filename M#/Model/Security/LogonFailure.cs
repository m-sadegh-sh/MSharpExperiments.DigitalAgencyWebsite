using MSharp;

namespace Security
{
    public class LogonFailure : EntityType
    {
        public LogonFailure()
        {
            Schema("Security");

            String("Email")
                .Mandatory();

            String("IP")
                .Mandatory();

            Int("Attempts")
                .Mandatory();

            DateTime("Date")
                .Mandatory();
        }
    }
}