using MSharp;

namespace Modules.Feature
{
    public class FeaturesList : ListModule<Domain.Feature>
    {
        public FeaturesList()
        {
            Search(GeneralSearch.AllFields)
                .Label("Find:");

            SearchButton("Search")
                .OnClick(x => x.Reload());

            Column(x => x.Title);

            Column(x => x.Description);

            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                /*M#:w[22]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<Pages.Dashboard.Cms.Features.EnterPage>().Send("item", "item.ID"));

            Button("New Feature").Icon(FA.Plus)
                /*M#:w[25]T-Prop:SendReturnUrl-Type:NavigateActivity-The destination page uses ReturnUrl which is not provided.*/.OnClick(x => x.Go<Pages.Dashboard.Cms.Features.EnterPage>());
        }
    }
}
