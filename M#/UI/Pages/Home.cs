using MSharp;

namespace Pages
{
    public class HomePage : RootPage
    {
        public HomePage()
        {
            Route("/");

            Layout(Layouts.Default);

            BrowserTitle("Geeks Digital Agency");

            Add<Modules.Slide.SlidesCarouselList>();
            //Add<Modules.Slide.FeatureLst>();
            //Add<Modules.Slide.About>();
            //Add<Modules.Slide.ClientLst>();
            //Add<Modules.Slide.TestimonyLst>();
            //Add<Modules.Slide.Contact>();

            Set(PageSettings.MainNav, "MainNav");
            Set(PageSettings.MainFooter, "Footer");
        }
    }
}