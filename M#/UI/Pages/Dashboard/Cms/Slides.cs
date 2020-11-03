using MSharp;

namespace Pages.Dashboard.Cms
{
    public class SlidesPage : SubPage<CmsPage>
    {
        public SlidesPage()
        {
            Add<Modules.Slide.SlidesList>();
        }
    }
}