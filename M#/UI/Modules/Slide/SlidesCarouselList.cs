using MSharp;

namespace Modules.Slide
{
    public class SlidesCarouselList : ListModule<Domain.Slide>
    {
        public SlidesCarouselList()
        {
            WrapInForm(false);
            SortingStatement("item.DisplayOrder");
            RenderMode(ListRenderMode.List);
            //MarkupWrapper("<div class='slideshow'>[#MODULE#]</div>");

            Markup(@"<img src='@item.Image' />
                <div class='info'><div>

                <span>@item.Title</span>
                <span>@item.Description</span>
                <a href='@item.LinkUrl'>@item.LinkText</a>

                </div></div>");
        }
    }
}