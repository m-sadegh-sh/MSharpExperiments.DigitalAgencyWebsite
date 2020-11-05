using MSharp;

namespace Pages.Dashboard.Cms.Features
{
    public class EnterPage : SubPage<FeaturesPage>
    {
        public EnterPage()
        {
            Add<Modules.Feature.FeatureForm>();
        }
    }
}
