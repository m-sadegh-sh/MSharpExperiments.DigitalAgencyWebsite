using MSharp;

namespace Cms
{
    public class ContentBlock : EntityType
    {
        public ContentBlock()
        {
            // Schema("Cms");

            InstanceAccessors(
                "PasswordSuccessfullyReset",
                "LoginIntro",
                "DashboardGreeting"
            );

            DefaultToString = String("Key")
                .Mandatory()
                .Unique();

            BigString("Content")
                .Mandatory();
        }
    }
}
