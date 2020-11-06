using MSharp;

namespace Modules.Client
{
    public class ClientsList : ListModule<Domain.Client>
    {
        public ClientsList()
        {
            Search(GeneralSearch.AllFields)
                .Label("Find:");

            SearchButton("Search")
                .OnClick(x => x.Reload());

            Column(x => x.Name);

            Column(x => x.Image);

            ButtonColumn("Edit")
                .HeaderText("Actions")
                .GridColumnCssClass("actions")
                .Icon(FA.Edit)
                .OnClick(x => x.Go<Pages.Dashboard.Cms.Clients.EnterPage>().Send("item", "item.ID"));

            Button("New Client")
                .Icon(FA.Plus)
                .OnClick(x => x.Go<Pages.Dashboard.Cms.Clients.EnterPage>());
        }
    }
}
