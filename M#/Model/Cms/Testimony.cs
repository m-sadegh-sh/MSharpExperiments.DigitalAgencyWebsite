using MSharp;

namespace Cms
{
    public class Testimony : EntityType
    {
        public Testimony()
        {
            Schema("Cms");

            String("Name")
                .Mandatory();

            String("Position")
                .Mandatory();

            String("Content")
                .Mandatory()
                .Max(2000)
                .Lines(5);

            OpenImage("Image")
                .Mandatory()
                .AutoOptimize(true)
                .PreserveTransparency(true);

            Int("Display order");
        }
    }
}