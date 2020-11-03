using MSharp;

namespace Cms
{
    public class Client : EntityType
    {
        public Client()
        {
            Schema("Cms");

            String("Name")
                .Mandatory();

            OpenImage("Image")
                .Mandatory()
                .AutoOptimize(true);
        }
    }
}