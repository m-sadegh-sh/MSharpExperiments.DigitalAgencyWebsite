using MSharp;

namespace Configuration
{
    public class GeneralSettings : EntityType
    {
        public GeneralSettings()
        {
            // Schema("Configuration");

            PluralName("General settings");

            InstanceAccessors("Current");

            String("Name")
                .Mandatory();

            Int("Password reset ticket expiry minutes")
                .Mandatory();

            Int("Cache version")
                .Mandatory();
        }
    }
}
