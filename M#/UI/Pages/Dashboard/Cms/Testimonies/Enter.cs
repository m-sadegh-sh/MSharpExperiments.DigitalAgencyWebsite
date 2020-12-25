using MSharp;

namespace Pages.Dashboard.Cms.Testimonies
{
    public class EnterPage : SubPage<TestimoniesPage>
    {
        public EnterPage()
        {
            Add<Modules.Testimony.TestimonyForm>();
        }
    }
}
