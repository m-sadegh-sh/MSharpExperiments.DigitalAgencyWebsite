using MSharp;

namespace Pages.Dashboard.Cms.Slides
{
    public class EnterPage : SubPage<SlidesPage>
    {
        /*M#:w[6]T-Prop:Name-Type:ApplicationPage-This page seems to be orphand. There is no standard Navigate Activity pointing to it.*/public EnterPage()
        {
            Add<Modules.Slide.SlideForm>();
        }
    }
}
