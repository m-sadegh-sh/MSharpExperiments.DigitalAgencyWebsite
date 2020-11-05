using MSharp;

namespace Modules.Slide
{
    public class SlidesList : ListModule<Domain.Slide>
    {
        public SlidesList()
        {
            HeaderText("Slides");

            Search(GeneralSearch.AllFields)
                .Label("Find:");

            SearchButton("Search")
                .OnClick(x => x.Reload());

            Column(x => x.Title);

            Column(x => x.Description);

            Column(x => x.Image);

            Column(x => x.LinkUrl);

            Column(x => x.LinkText);

            Column(x => x.DisplayOrder);

            LoadJavascriptModule("/scripts/components/SlidesCarouselModule");

            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                .OnClick(x => x.Go<Pages.Dashboard.Cms.Slides.EnterPage>().Send("item", "item.ID"));

            Button("New Slide")
                .Icon(FA.Plus)
                .OnClick(x => x.Go<Pages.Dashboard.Cms.Slides.EnterPage>());
        }
    }
}
