using MSharp;

namespace Pages.Dashboard.Cms.Slides
{
    public class EnterPage : SubPage<SlidesPage>
    {
        public EnterPage()
        {
            Add<Modules.Slide.SlideForm>();
        }
    }
}
