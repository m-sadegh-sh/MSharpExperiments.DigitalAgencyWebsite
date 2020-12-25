using MSharp;

namespace Pages.Dashboard.Cms
{
    public class TestimoniesPage : SubPage<CmsPage>
    {
        public TestimoniesPage()
        {
            Add<Modules.Testimony.TestimoniesList>();
        }
    }
}