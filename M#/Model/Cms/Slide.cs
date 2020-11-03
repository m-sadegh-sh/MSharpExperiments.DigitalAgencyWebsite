using MSharp;

namespace Cms
{
    public class Slide : EntityType
    {
        public Slide()
        {
            Schema("Cms");

            String("Title")
                .Mandatory();

            String("Description")
                .Mandatory()
                .Max(2000)
                .Lines(5);

            OpenImage("Image")
                .Mandatory()
                .AutoOptimize(true)
                .Width(1600)
                .Height(600);

            String("Link url")
                .Accepts(TextPattern.InternetURL);

            String("Link text");

            Int("Display order");
        }
    }
}