using MSharp;

namespace Pages.Dashboard.Cms
{
    public class FeaturesPage : SubPage<CmsPage>
    {
        public FeaturesPage()
        {
            Add<Modules.Feature.FeaturesList>();
        }
    }
}