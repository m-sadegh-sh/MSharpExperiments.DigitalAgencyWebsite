using MSharp;

namespace Security
{
    public class AuditEvent : EntityType
    {
        public AuditEvent()
        {
            Schema("Security");

            Cachable(false)
                .Implements("Olive.Audit.IAuditEvent");

            String("User id");

            DateTime("Date")
                .Mandatory()
                .Default(cs("LocalTime.Now"))
                .DefaultFormatString("g");

            String("Event")
                .Mandatory();

            String("Item type");

            String("Item id", 500);

            BigString("Item data");

            String("User Ip");
        }
    }
}