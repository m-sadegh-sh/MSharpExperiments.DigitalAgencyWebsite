using MSharp;

namespace Modules.Testimony
{
    public class TestimoniesList : ListModule<Domain.Testimony>
    {
        public TestimoniesList()
        {
            Search(GeneralSearch.AllFields)
                .Label("Find:");

            SearchButton("Search")
                .OnClick(x => x.Reload());

            Column(x => x.Name);

            Column(x => x.Position);

            Column(x => x.Content);

            Column(x => x.Image);

            Column(x => x.DisplayOrder);

            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                .OnClick(x => x.Go<Pages.Dashboard.Cms.Testimonies.EnterPage>().Send("item", "item.ID"));

            Button("New Testimony").Icon(FA.Plus)
                .OnClick(x => x.Go<Pages.Dashboard.Cms.Testimonies.EnterPage>());
        }
    }
}
