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
            
            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                /*M#:w[32]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<Pages.Dashboard.Cms.ContentBlocks.EnterPage>().Send("item", "item.ID"));
            
            Button("New Slide")
                .Icon(FA.Plus)
                /*M#:w[36]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<Pages.Dashboard.Cms.ContentBlocks.EnterPage>());
        }
    }
}
