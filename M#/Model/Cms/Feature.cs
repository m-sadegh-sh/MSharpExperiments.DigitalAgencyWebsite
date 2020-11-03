using MSharp;

namespace Cms
{
    public class Feature : EntityType
    {
        public Feature()
        {
            Schema("Cms");

            String("Title")
                .Mandatory();

            String("Description")
                .Mandatory()
                .Max(2000)
                .Lines(5);
        }
    }
}