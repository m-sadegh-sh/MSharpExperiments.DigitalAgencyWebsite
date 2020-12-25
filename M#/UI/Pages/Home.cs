using MSharp;

namespace Pages
{
    public class HomePage : RootPage
    {
        public HomePage()
        {
            Route("/")
                .Layout(Layouts.Default)
                .BrowserTitle("Geeks Digital Agency");

            Add<Modules.Slide.SlidesCarouselList>();
            Add<Modules.Feature.FeaturesTopList>();
            Add<Modules.Client.ClientsCarouselList>();
            Add<Modules.Custom.About>();
            Add<Modules.Testimony.TestimoniesCarouselList>();
            Add<Modules.Custom.Contact>();

            Set(PageSettings.MainNav, "MainNav");
            Set(PageSettings.MainFooter, "Footer");
        }
    }
}