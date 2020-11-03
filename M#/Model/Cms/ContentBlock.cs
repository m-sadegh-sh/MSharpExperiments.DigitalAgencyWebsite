using MSharp;

namespace Cms
{
    public class ContentBlock : EntityType
    {
        public ContentBlock()
        {
            // Schema("Cms");

            InstanceAccessors("PasswordSuccessfullyReset", "LoginIntro");

            DefaultToString = String("Key")
                .Mandatory()
                .Unique();

            BigString("Content")
                .Mandatory();
        }
    }
}
